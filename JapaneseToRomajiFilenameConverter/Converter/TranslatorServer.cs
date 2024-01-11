using System;
using System.Diagnostics;
using System.IO;

namespace JapaneseToRomajiFilenameConverter.Converter {
    class TranslatorServer {

        static TranslatorServer instance = null;
        public static TranslatorServer Instance {

            get {

                if(instance == null)
                    instance = new TranslatorServer();

                return instance;
            }
        }

        Process libreTranslateServer;
        Process pykakasiServer;

        public bool IsServerRunning() {

            return libreTranslateServer != null && pykakasiServer != null && !libreTranslateServer.HasExited && !pykakasiServer.HasExited;
        }

        public void StartServer() {

            if(!IsServerRunning()) {

                if(libreTranslateServer == null) {

                    libreTranslateServer = new Process();
                    libreTranslateServer.StartInfo = new ProcessStartInfo("libretranslate") {
                        UseShellExecute = false
                    };
                }

                libreTranslateServer.Start();

                if(pykakasiServer == null) {

                    pykakasiServer = new Process();
                    pykakasiServer.StartInfo = new ProcessStartInfo("python", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res/pykakasi/pykakasi_api.py")) {
                        UseShellExecute = false
                    };
                }

                pykakasiServer.Start();
            }
        }

        public void StopServer() {

            if(IsServerRunning()) {

                libreTranslateServer.CloseMainWindow();
                pykakasiServer.CloseMainWindow();
            }
        }

        public void RestartServer() {

            StopServer();
            StartServer();
        }
    }
}
