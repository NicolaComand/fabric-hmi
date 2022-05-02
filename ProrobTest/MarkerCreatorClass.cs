using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest
{
    class MarkerCreatorClass : Observable
    {
        public enum State
        {
            IDLE,
            MARKER_NOT_VALID,
            MARKER_VALID,
            IDLE_NOT_FIRST_MARKER,
            IDLE_NOTE_FIRST_MARKER_START_ENABLED,
            SUB_MARKER_ENABLE_START,
            SUB_MARKER_INVALID,
            SUB_MARKER_VALID,
            SUB_MARKER_CLOSED,
            VALID_MARKER_WITH_SUBMARKERS,
            INVALID_MARKER_WITH_SUBMARKERS,
            INVALID_MARKER_AND_SUBMARKER
        }

        private int _actualSliderPosition;
        public int ActualSliderPosition { get { return _actualSliderPosition; } set { _actualSliderPosition = value; CurrentPosition = MaximumPosition - value; this.NotifyObservers(0); this.CheckConditions(); } }
        private int _currentPosition;
        public int CurrentPosition { get { return _currentPosition; } set { _currentPosition = value; } }
        private State _stato = State.IDLE;
        public State Stato { get { return _stato; } set { _stato = value; this.NotifyObservers(0); } }
        public List<Marker> MarkerList = new List<Marker>();
        
        // Temporary objects used during marker building
        public Marker CreatingMarker;
        public Marker CreatingSubMarker;

        // Settings
        public int MaximumPosition = 4000;
        public int MarkersDistance = 50;            

        public MarkerCreatorClass()
        {
        }
        public MarkerCreatorClass(int position)
        {
            ActualSliderPosition = position;
        }

        public void OpenMarker()
        {
            CreatingMarker = new Marker
            {
                startPosition = ActualSliderPosition,
                index = MarkerList.Count,
                offset = MarkersDistance
            };

            Stato = State.MARKER_NOT_VALID;
        }
        public void AutoOpenMarker(int position)
        {
            CreatingMarker = new Marker
            {
                startPosition = position,
                index = MarkerList.Count,
                offset = MarkersDistance
            };

            Stato = State.MARKER_NOT_VALID;
        }

        public void CloseMarker()
        {
            CreatingMarker.stopPosition = ActualSliderPosition;
            MarkerList.Add(CreatingMarker);
            CreatingMarker = null;

            Stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;

        }

        public void OpenSubMarker()
        {
            CreatingSubMarker = new Marker
            {
                startPosition = ActualSliderPosition,
                index = CreatingMarker.index
            };

            Stato = State.SUB_MARKER_INVALID;
        }

        public void CloseSubMarker()
        {
            CreatingSubMarker.stopPosition = ActualSliderPosition;
            CreatingMarker.subMarkers.Add(CreatingSubMarker);
            CreatingSubMarker = null;

            Stato = State.SUB_MARKER_CLOSED;
        }

        public void CheckConditions()
        {
            
            int tempMarkerWidth = 0;
            int tempSubMarkerWidth = 0;
            bool condition;

            // Calculate theoretical length of currently markers being built
            if (CreatingMarker != null)
            {
                tempMarkerWidth = ActualSliderPosition - CreatingMarker.startPosition;
            }
            if (CreatingSubMarker != null)
            {
                tempSubMarkerWidth = ActualSliderPosition - CreatingSubMarker.startPosition;
            }
                        

            switch (Stato)
            {

                case State.IDLE:
                    // Initial condition, no markers or submarkers
                    break;
                case State.MARKER_NOT_VALID:

                    if (MarkerList.Count == 0)
                    {
                        condition = tempMarkerWidth > 0;
                    }
                    else
                    {
                        condition = tempMarkerWidth > 0 && ActualSliderPosition > MarkerList.Last().stopPosition;
                    }

                    if (condition)
                    {
                        Stato = State.MARKER_VALID;
                    }
                    break;

                case State.MARKER_VALID:

                    if (MarkerList.Count == 0)
                    {
                        condition = tempMarkerWidth <= 0;
                    }
                    else
                    {
                        condition = tempMarkerWidth <= 0 || ActualSliderPosition < MarkerList.Last().stopPosition;
                    }

                    if (condition)
                    {
                        Stato = State.MARKER_NOT_VALID;
                    }
                    break;

                case State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:

                    if (ActualSliderPosition <= MarkerList.Last().startPosition)
                    {
                        Stato = State.IDLE_NOT_FIRST_MARKER;
                    }

                    if (ActualSliderPosition >= MarkerList.Last().stopPosition + MarkersDistance)
                    {
                        //Automatic Marker Start
                        AutoOpenMarker(MarkerList.Last().stopPosition + MarkersDistance);
                    }
                    break;

                case State.IDLE_NOT_FIRST_MARKER:

                    if (ActualSliderPosition > MarkerList.Last().startPosition)
                    {
                        Stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;
                    }
                    break;

                case State.SUB_MARKER_INVALID:
                    if (tempSubMarkerWidth > 0)
                    {
                        Stato = State.SUB_MARKER_VALID;
                    }
                    break;

                case State.SUB_MARKER_VALID:

                    if (tempSubMarkerWidth <= 0)
                    {
                        Stato = State.SUB_MARKER_INVALID;
                    }
                    break;

                case State.SUB_MARKER_CLOSED:

                    if (ActualSliderPosition >= CreatingMarker.subMarkers.Last().stopPosition)
                    {
                        Stato = State.VALID_MARKER_WITH_SUBMARKERS;
                    }
                    else
                    {
                        Stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                case State.VALID_MARKER_WITH_SUBMARKERS:

                    if (ActualSliderPosition < CreatingMarker.subMarkers.Last().stopPosition)
                    {
                        Stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                case State.INVALID_MARKER_WITH_SUBMARKERS:

                    if (ActualSliderPosition >= CreatingMarker.subMarkers.Last().stopPosition)
                    {
                        Stato = State.VALID_MARKER_WITH_SUBMARKERS;
                    }
                    else if (ActualSliderPosition <= CreatingMarker.subMarkers.Last().startPosition)
                    {
                        Stato = State.INVALID_MARKER_AND_SUBMARKER;
                    }
                    break;

                case State.INVALID_MARKER_AND_SUBMARKER:

                    if (ActualSliderPosition > CreatingMarker.subMarkers.Last().startPosition)
                    {
                        Stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                default:
                    break;
            }
        }

    }
}
