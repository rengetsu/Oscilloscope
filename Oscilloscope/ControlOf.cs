using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class ControlOf
    {
        DeviceCheck DC;

        Boolean LowJitter_FreeRun_InstrumentSettings = false;

        String FW_Ver = "FW_Ver";

        public int SettedPreTriggerPoint;

        //  Tutorials variables
        private int tutSigLen_OutPoint;
        private int tutPreTrigger_OutPnts;

        public int OldValueOfPriborParameters { get; private set; }

        /// <summary>
        /// Hold Off Random Min Max send to device (pribor)
        /// </summary>
        /// <param name="Max">Max or Not</param>
        /// <param name="HoldRandTime">Hold Rand Time</param>
        public void HoldOffRandomMinMaxToPribor(Boolean Max, Double HoldRandTime)
        {
            String Mn;

            if( isNewHoldoff_V3_1() )
            {
                if( Max )
                {
                    Mn = "RandTMax";
                }
                else
                {
                    Mn = "RandTmin";
                }

                SetFloatParameter("Trig:HoldOff:" + Mn, HoldRandTime);
            }
        }

        private Boolean isNewHoldoff_V3_1()
        {
            int[] ZV = { 3, 1, 0, 0 };
            Boolean result = VersionEqualOrNewer(FW_Ver, ZV);
            return result;
        }

        private bool VersionEqualOrNewer(string fW_Ver, int[] ZV)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Record Length sending with command send to device (pribor)
        /// </summary>
        /// <param name="RecordLength">Record Length</param>
        /// <param name="WithoutTerminateSbor">Without Terminate Sbor or not</param>
        /// <param name="Code_LJ_Freerun">LJ Freerun Code</param>
        public void RecordLengthToPribor(int RecordLength, Boolean WithoutTerminateSbor = false, int Code_LJ_Freerun = 0)
        {
            String com;

            if( Code_LJ_Freerun == -1)
            {
                RecordLength = OldValueOfPriborParameters;
            }
            else
            {
                if( RecordLength == OldValueOfPriborParameters )
                {
                    //  Exit
                    return;
                }
            }

            if( Code_LJ_Freerun != 1 )
            {
                OldValueOfPriborParameters = RecordLength;
            }

            //  В режиме Low Jitter параметры только запоминаются, но в прибор не передаются!
            if ( (LowJitter_FreeRun_InstrumentSettings) && (Code_LJ_Freerun == 0))
            {
                //  Exit
                return;
            }

            //  29/09/2021  Добавили +16 точек для Arrow
            RecordLength = RecordLength + 16;

            com = RecordLength.ToString();
            com = "Acq:RecordLen " + com;

            DC.SendCommantToTheUnit(com);

            //  29/09/2021  Добавили +16 точек для Arrow
            SetRecordLengthIntoTutorial(RecordLength + 16);
        }

        /// <summary>
        /// TimeBase Pre Trigger Points send to device (pribor)
        /// </summary>
        /// <param name="PreTrigPnts"></param>
        /// <param name="Code_LJ_Freerun"></param>
        public void TB_PreTriggerPoints_ToPribor(int PreTrigPnts, int Code_LJ_Freerun = 0)
        {
            //  Величина предзаписи в точках, 0 … 500 000.
            //  0 - предзаписи нет, = ACQ:RECORDLEN - 100% - точка триггера в конце сигнала; Применяется в RT и RANDOM модах.
            //  До этой команды действовала команда PRETRIGPERC, но в связи с рандомом возникла потребность в предзаписи,
            //  выраженной в долях точки. Поэтому теперь предзапись рассчитывает верхняя программа.
            //  Целое значение точек передает в прибор, а дробное учитывает сама.
            //  Должна обязательно сопровождать ACQ:RECORDLEN в RT и Random!

            if ( Code_LJ_Freerun == -1 )
            {
                PreTrigPnts = OldValueOfPriborParameters;
            }
            else
            {
                if( PreTrigPnts == OldValueOfPriborParameters)
                {
                    //  Exit
                    return;
                }
            }

            if ( Code_LJ_Freerun != 1 )
            {
                OldValueOfPriborParameters = PreTrigPnts;
            }

            if( (LowJitter_FreeRun_InstrumentSettings) && (Code_LJ_Freerun == 0 ) )
            {
                //  В режиме Low Jitter параметры только запоминаются, но в прибор не передаются!
                //  Exit
                return;
            }

            //  29/09/2021  Добавили +16 точек для Arrow
            PreTrigPnts = PreTrigPnts + 16;

            DC.SetIntegerParameter("TB:PRETRIGPNT", PreTrigPnts);

            SettedPreTriggerPoint = PreTrigPnts;

            SetPreTriggerPointsIntoTutorial(PreTrigPnts);
        }

        /// <summary>
        /// Set Pre Trigger Point Into Tutorial
        /// </summary>
        /// <param name="preTrigPoints">Pre Trig Points</param>
        private void SetPreTriggerPointsIntoTutorial(int preTrigPoints)
        {
            tutPreTrigger_OutPnts = preTrigPoints;
        }

        /// <summary>
        /// Set Record Length Into Tutorial
        /// </summary>
        /// <param name="RecordLength">Record Length</param>
        private void SetRecordLengthIntoTutorial(int RecordLength)
        {
            tutSigLen_OutPoint = RecordLength;
        }
    }
}
