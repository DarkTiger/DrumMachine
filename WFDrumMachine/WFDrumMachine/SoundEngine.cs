using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace WFDrumMachine
{
    class SoundEngine : IDisposable
    {

        private readonly IWavePlayer outputDevice;
        private readonly MixingSampleProvider mixer;


        public SoundEngine(int sampleRate = 44100, int channelCount = 2)
        {
            outputDevice = new NAudio.Wave.WasapiOut(NAudio.CoreAudioApi.AudioClientShareMode.Shared, 0);
            //outputDevice = new NAudio.Wave.DirectSoundOut(50);
            mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channelCount));
            mixer.ReadFully = true;
            outputDevice.Init(mixer);
            outputDevice.Play();
        }


        public void PlaySound(string fileName)
        {
            var input = new AudioFileReader(fileName);
            AddMixerInput(new AutoDisposeFileReader(input));
        }


        public void StopSound()
        {
            outputDevice.Stop();
        }


        private ISampleProvider ConvertToRightChannelCount(ISampleProvider input)
        {

            if (input.WaveFormat.Channels == mixer.WaveFormat.Channels)
            {
                return input;
            }
            if (input.WaveFormat.Channels == 1 && mixer.WaveFormat.Channels == 2)
            {
                return new MonoToStereoSampleProvider(input);
            }
            
            throw new NotImplementedException("Not yet implemented this channel count conversion");
        }


        public void PlaySound(CachedSound sound)
        {
            AddMixerInput(new CachedSoundSampleProvider(sound));
        }


        private void AddMixerInput(ISampleProvider input)
        {
            mixer.AddMixerInput(ConvertToRightChannelCount(input));
        }


        public void Dispose()
        {
            outputDevice.Dispose();
        }


        public static readonly SoundEngine Instance = new SoundEngine(44100, 2);




        ////////CLASSE WINMM//////////
        /*private string Pcommand;
        private bool isOpen;


         [DllImport("Winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
                
        public SoundEngine()
        {
        }

        /// <summary>
        /// Stops currently playing audio file
        /// </summary>
        public void Close()
        {
            Pcommand = "close MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        /// <summary>
        /// Opens audio file to play
        /// </summary>
        /// <param name="sFileName">This is the audio file's path and filename</param>
        public void Open(string sFileName, string alias)
        {
            Pcommand = "open \"" + sFileName + "\" type waveaudio alias " + alias; //mpegvideo X mp3
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        /// <summary>
        /// Plays selected audio file
        /// </summary>
        /// <param name="loop">If True,audio file will repeat</param>
        public void Play(bool loop, string alias)
        {
            if (isOpen)
            {
                Pcommand = "play " + alias;
                if (loop)
                {
                    Pcommand += " REPEAT";
                }
                else
                {
                    mciSendString(Pcommand, null, 0, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// Pauses currently playing audio file
        /// </summary>
        public void Pause()
        {
            Pcommand = "pause MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Returns the current status player: playing,paused,stopped etc.
        /// </summary>
        public string Status()
        {
            int i = 128;
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(i);
            mciSendString("status MediaFile mode", stringBuilder, i, IntPtr.Zero);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Get/Set Lelf Volume Factor
        /// </summary>
        public int LeftVolume
        {
            get
            {
                return 0; //Guess could be used to return Volume level: I don't need it
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile left volume to ", value), null, 0, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Get/Set Right Volume Factor
        /// </summary>
        public int RightVolume
        {
            get
            {
                return 0; //Guess could be used to return Volume level: I don't need it
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile right volume to ", value), null, 0, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Get/Set Main Volume Factor
        /// </summary>
        public int MasterVolume
        {
            get
            {
                return 0; //Guess could be used to return Volume level: I don't need it
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile volume to ", value), null, 0, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Get/Set Bass Volume Factor
        /// </summary>
        public int Bass
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile bass to ", value), null, 0, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Get/Set Treble Volume Factor
        /// </summary>
        public int Treble
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile treble to ", value), null, 0, IntPtr.Zero);
            }
        }*/


        //////////CLASSE SOUNDPLAYER/////////////
        /*SoundPlayer sp = new SoundPlayer();

         public SoundEngine(string soundPath)
         {
             InitializeSound(soundPath);
         }

         private void InitializeSound(string soundPath)
         {
             if (File.Exists(soundPath)) //(File.Exists(Environment.CurrentDirectory + @"\Sounds\BeepLow.wav"))
             {
                 sp.SoundLocation = soundPath; //Environment.CurrentDirectory + @"\Sounds\BeepLow.wav";
                 sp.LoadAsync();
             }
             else
             {
                 throw new Exception("File audio non presente: '" + soundPath + "'");
             }

             if (!sp.IsLoadCompleted)
             {
                 throw new Exception("Audio non caricato correttamente!");
             }
         }

         public void PlaySound()
         {
             sp.Play();
         }

         public void StopSound()
         {
             sp.Stop();
         }
         */
    }
}
