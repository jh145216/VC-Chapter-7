using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MUsciTest
{
    class MP3Player
    {
        SoundPlayer simpleSound = new SoundPlayer(strAudioFilePath);
        simpleSound.PlaySync();
    }
}
