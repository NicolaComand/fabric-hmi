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
        public int actualSliderPosition { get { return _actualSliderPosition; } set { _actualSliderPosition = value; currentPosition = maximumPosition - value; this.NotifyObservers(0); this.CheckConditions(); } }
        private int _currentPosition;
        public int currentPosition { get { return _currentPosition; } set { _currentPosition = value; } }
        private State _stato = State.IDLE;
        public State stato { get { return _stato; } set { _stato = value; this.NotifyObservers(0); } }
        public List<Marker> markerList = new List<Marker>();
        
        // Temporary objects used during marker building
        public Marker creatingMarker;
        public Marker creatingSubMarker;

        // Settings
        public int maximumPosition = 4000;
        int markersDistance = 50;
            

        public MarkerCreatorClass()
        {
        }
        public MarkerCreatorClass(int position)
        {
            actualSliderPosition = position;
        }

        public void OpenMarker()
        {
            creatingMarker = new Marker
            {
                startPosition = actualSliderPosition,
                index = markerList.Count,
                offset = markersDistance
            };

            stato = State.MARKER_NOT_VALID;
        }
        public void AutoOpenMarker(int position)
        {
            creatingMarker = new Marker
            {
                startPosition = position,
                index = markerList.Count,
                offset = markersDistance
            };

            stato = State.MARKER_NOT_VALID;
        }

        public void CloseMarker()
        {
            creatingMarker.stopPosition = actualSliderPosition;
            markerList.Add(creatingMarker);
            creatingMarker = null;

            stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;

        }

        public void OpenSubMarker()
        {
            creatingSubMarker = new Marker
            {
                startPosition = actualSliderPosition,
                index = creatingMarker.index
            };

            stato = State.SUB_MARKER_INVALID;
        }

        public void CloseSubMarker()
        {
            creatingSubMarker.stopPosition = actualSliderPosition;
            creatingMarker.subMarkers.Add(creatingSubMarker);
            creatingSubMarker = null;

            stato = State.SUB_MARKER_CLOSED;

        }


        public void CheckConditions()
        {

            
            int tempMarkerWidth = 0;
            int tempSubMarkerWidth = 0;
            bool condition;

            // Calculate theoretical length of currently markers being built
            if (creatingMarker != null)
            {
                tempMarkerWidth = actualSliderPosition - creatingMarker.startPosition;
            }
            if (creatingSubMarker != null)
            {
                tempSubMarkerWidth = actualSliderPosition - creatingSubMarker.startPosition;
            }
                        

            switch (stato)
            {

                case State.IDLE:
                    // Initial condition, no markers or submarkers
                    break;
                case State.MARKER_NOT_VALID:

                    if (markerList.Count == 0)
                    {
                        condition = tempMarkerWidth > 0;
                    }
                    else
                    {
                        condition = tempMarkerWidth > 0 && actualSliderPosition > markerList.Last().stopPosition;
                    }

                    if (condition)
                    {
                        stato = State.MARKER_VALID;
                    }
                    break;

                case State.MARKER_VALID:

                    if (markerList.Count == 0)
                    {
                        condition = tempMarkerWidth <= 0;
                    }
                    else
                    {
                        condition = tempMarkerWidth <= 0 || actualSliderPosition < markerList.Last().stopPosition;
                    }

                    if (condition)
                    {
                        stato = State.MARKER_NOT_VALID;
                    }
                    break;

                case State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:

                    if (actualSliderPosition <= markerList.Last().startPosition)
                    {
                        stato = State.IDLE_NOT_FIRST_MARKER;
                    }

                    if (actualSliderPosition >= markerList.Last().stopPosition + markersDistance)
                    {
                        //Automatic Marker Start
                        AutoOpenMarker(markerList.Last().stopPosition + markersDistance);
                    }
                    break;

                case State.IDLE_NOT_FIRST_MARKER:

                    if (actualSliderPosition > markerList.Last().startPosition)
                    {
                        stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;
                    }
                    break;

                case State.SUB_MARKER_INVALID:
                    if (tempSubMarkerWidth > 0)
                    {
                        stato = State.SUB_MARKER_VALID;
                    }
                    break;

                case State.SUB_MARKER_VALID:

                    if (tempSubMarkerWidth <= 0)
                    {
                        stato = State.SUB_MARKER_INVALID;
                    }
                    break;

                case State.SUB_MARKER_CLOSED:

                    if (actualSliderPosition >= creatingMarker.subMarkers.Last().stopPosition)
                    {
                        stato = State.VALID_MARKER_WITH_SUBMARKERS;
                    }
                    else
                    {
                        stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                case State.VALID_MARKER_WITH_SUBMARKERS:

                    if (actualSliderPosition < creatingMarker.subMarkers.Last().stopPosition)
                    {
                        stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                case State.INVALID_MARKER_WITH_SUBMARKERS:

                    if (actualSliderPosition >= creatingMarker.subMarkers.Last().stopPosition)
                    {
                        stato = State.VALID_MARKER_WITH_SUBMARKERS;
                    }
                    else if (actualSliderPosition <= creatingMarker.subMarkers.Last().startPosition)
                    {
                        stato = State.INVALID_MARKER_AND_SUBMARKER;
                    }
                    break;

                case State.INVALID_MARKER_AND_SUBMARKER:

                    if (actualSliderPosition > creatingMarker.subMarkers.Last().startPosition)
                    {
                        stato = State.INVALID_MARKER_WITH_SUBMARKERS;
                    }
                    break;

                default:
                    break;
            }
        }

    }
}
