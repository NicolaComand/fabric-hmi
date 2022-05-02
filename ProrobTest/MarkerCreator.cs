using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest
{
    class MarkerCreator : Observable
    {
        //public int actualSliderPosition;
        private int _actualSliderPosition;
        public int actualSliderPosition { get { return _actualSliderPosition; } set { _actualSliderPosition = value; this.NotifyObservers(0); this.CheckConditions(); } }

        int markerStart = 0;

        public int maximumPosition = 4000;
        int markersDistance = 50;

        public Marker creatingMarker;
        public Marker creatingSubMarker;
        //Marker completedSubMarker = new Marker();

        int subMarkerStart = 0;


        public List<Marker> markerList = new List<Marker>();

        //public State stato = State.MARKER_START_ENABLED;

        private State _stato = State.IDLE;

        public State stato  { get { return _stato; } set { _stato = value; this.NotifyObservers(0); } }

        public MarkerCreator()
        {
            stato = State.IDLE;
            //InitDebug();
        }

        public MarkerCreator(int position)
        {
            actualSliderPosition = position;
        }


        public void OpenMarker()
        {
            creatingMarker = new Marker();
            creatingMarker.startPosition = actualSliderPosition;
            creatingMarker.index = markerList.Count; //TODO: Si può fare una lista che gestisce da sola l'indice
            creatingMarker.offset = markersDistance;

            // TODO: togliere markerStart
            markerStart = actualSliderPosition;
            stato = State.MARKER_NOT_VALID;            
        }

        public void CloseMarker()
        {
            creatingMarker.stopPosition = actualSliderPosition;

            //creatingMarker = new Marker(markerStart, actualSliderPosition);
            markerList.Add(creatingMarker);

            creatingMarker = null;
            stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;

        }

        public void OpenSubMarker()
        {
            creatingSubMarker = new Marker();
            creatingSubMarker.startPosition = actualSliderPosition;
            creatingSubMarker.index = creatingMarker.index;

            // TODO: togliere subMarkerStart
            subMarkerStart = actualSliderPosition;
            stato = State.SUB_MARKER_INVALID;
        }

        public void CloseSubMarker()
        {
            creatingSubMarker.stopPosition = actualSliderPosition;

            //Marker completedSubMarker = new Marker(subMarkerStart, actualSliderPosition);
            creatingMarker.subMarkers.Add(creatingSubMarker);
            creatingSubMarker = null;

            stato = State.SUB_MARKER_CLOSED;

        }


        private void InitDebug()
        {
            Marker m = new Marker(1000, 1500);
            markerList.Add(m);

            m = new Marker(2000, 3000);
            markerList.Add(m);

        }




        int  tempMarkerWidth  = 0;
        int tempSubMarkerWidth = 0;

        public void CheckConditions()
        {
            tempMarkerWidth = actualSliderPosition - markerStart;
            tempSubMarkerWidth = actualSliderPosition - subMarkerStart;

            bool condition;

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
                        //CheckConditions();
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
                        //CheckConditions();
                    }
                    break;


                case State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:

                    if (actualSliderPosition <= markerList.Last().startPosition)
                    {
                        stato = State.IDLE_NOT_FIRST_MARKER;
                    }


                    if (actualSliderPosition >= markerList.Last().stopPosition + markersDistance)
                    {
                        //Inizio automatico
                        this.OpenMarker();

                    }

                    break;



                case State.IDLE_NOT_FIRST_MARKER:

                    if (actualSliderPosition > markerList.Last().startPosition)
                    {
                        stato = State.IDLE_NOTE_FIRST_MARKER_START_ENABLED;
                    }

                    break;



                //case State.NOT_FIRST_MARKER_VALID:


                //    if (actualSliderPosition <= markerList.Last().startPosition)
                //    {
                //        stato = State.IDLE_NOT_FIRST_MARKER;
                //    }



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
                    if (actualSliderPosition >= creatingMarker.subMarkers.Last().stopPosition )
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
            INVALID_MARKER_AND_SUBMARKER,
            //NOT_FIRST_MARKER_VALID
        }















    }
}
