using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;
using System.Threading;

namespace MusicPlayer
{
    public class BassHelper
    {
        public delegate void FFTChanged(float[] fft);
        public event FFTChanged ChangeFFT;
        Thread fftThread;
        int Stream_playmusic;
        /// <summary>
        /// BassHelper
        /// </summary>
        public BassHelper() {
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            fftThread = new Thread(GetFFTData);
            fftThread.Start();
        }
        /// <summary>
        /// 加载音频文件
        /// </summary>
        /// <param name="filePath">路径</param>
        /// <returns></returns>
        public bool LoadSound(string filePath) {
            Stream_playmusic = Bass.BASS_StreamCreateFile(filePath, 0, 0, BASSFlag.BASS_MUSIC_FLOAT);
            string[] soundinfo = Bass.BASS_ChannelGetTagsID3V2(Stream_playmusic);
            
            return true;
        }
        /// <summary>
        /// 加载音频流
        /// </summary>
        /// <param name="streamByte">字节流</param>
        /// <returns></returns>
        public bool LoadSound(byte[] streamByte) {
            Stream_playmusic = Bass.BASS_MusicLoad(streamByte, 0L, streamByte.Length, BASSFlag.BASS_DEFAULT, 44100);
            return true;
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <returns></returns>
        public bool Play() {
            if (Bass.BASS_ChannelIsActive(Stream_playmusic) != BASSActive.BASS_ACTIVE_PLAYING) {
                return Bass.BASS_ChannelPlay(Stream_playmusic, false);
            }
            else {
                return true;
            }
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <returns></returns>
        public bool Pause() {
            if (Bass.BASS_ChannelIsActive(Stream_playmusic) != BASSActive.BASS_ACTIVE_PAUSED) {
                return Bass.BASS_ChannelPause(Stream_playmusic);
            }else{
                return true;
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <returns></returns>
        public bool Stop() {
            if (Bass.BASS_ChannelIsActive(Stream_playmusic) != BASSActive.BASS_ACTIVE_STOPPED) {
                return Bass.BASS_ChannelStop(Stream_playmusic);
            }
            else {
                return true;
            }
        }


        /// <summary>
        /// fft采样
        /// </summary>
        /// <returns></returns>
        public void GetFFTData()
        {
            while (true) {
                if (ChangeFFT != null) {
                    float[] fft = new float[1024];
                    Bass.BASS_ChannelGetData(Stream_playmusic, fft, (int)BASSData.BASS_DATA_FFT1024);
                    ChangeFFT(fft);
                }
            }
        }

        /// <summary>
        /// 资源释放
        /// </summary>
        public void Disponse() {
            fftThread.Abort();
            Bass.BASS_ChannelStop(Stream_playmusic);
            Bass.BASS_StreamFree(Stream_playmusic);
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }

        /// <summary>
        /// 播放时间
        /// </summary>
        public double CurrentTime {
            get { return Bass.BASS_ChannelBytes2Seconds(Stream_playmusic, Bass.BASS_ChannelGetPosition(Stream_playmusic)); }
            set { Bass.BASS_ChannelSetPosition(Stream_playmusic, value); }
        }

        /// <summary>
        /// 音频总时间
        /// </summary>
        public double Duration {
            get { return Bass.BASS_ChannelBytes2Seconds(Stream_playmusic, Bass.BASS_ChannelGetLength(Stream_playmusic)); }
        }

        /// <summary>
        /// 音量
        /// </summary>
        public int Volume {
            get { return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM) / 100; }
            set { Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, value * 100); }
        }
    }
}
