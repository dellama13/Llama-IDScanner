using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssureTec.AssureID.SDK;

namespace Llama_IDScanner.Scanner
{
    

    public partial class AssuretecScanner
    {
        public readonly AssureIDSession AssureIdServiceSession = new AssureIDSession();


        public ScanStatus ScannerStatus
        {
            get
            {
                switch (AssureIdServiceSession.PlatformStatus)
                {
                    case PlatformState.ActivationRequired:
                        return ScanStatus.Error;
                    case PlatformState.Any:
                        return ScanStatus.Other;
                    case PlatformState.Busy:
                        return ScanStatus.Busy;
                    case PlatformState.Disconnected:
                        return ScanStatus.Disconnected;
                    case PlatformState.Error:
                        return ScanStatus.Error;
                    case PlatformState.Ready:
                        return ScanStatus.Ready;
                    case PlatformState.Starting:
                        return ScanStatus.Starting;
                    case PlatformState.Stopped:
                        return ScanStatus.Stopped;
                    case PlatformState.Stopping:
                        return ScanStatus.Stopping;
                    default:
                        return ScanStatus.Other;
                }
            }
        }



    }
}
