using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llama_IDScanner.Scanner
{
    public enum ScanStatus
    {

        Error,
        Invalid,
        Valid,
        Expired,
        NotDetermined,
        AuthenticationNotSupported,
        AuthenticationTurnedOff,
        NeedsCalibration,
        Initializing,
        Busy,
        Ready,
        Disconnected,
        Other,
        Starting,
        Stopped,
        Stopping


    };
}
