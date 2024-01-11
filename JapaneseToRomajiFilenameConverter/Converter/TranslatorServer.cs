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

        bool IsLibreTranslateServerRunning() {

            return libreTranslateServer != null && !libreTranslateServer.HasExited;
        }

        bool IsPykakasiServerRunning() {

            return pykakasiServer != null && !pykakasiServer.HasExited;
        }

        public void StartServer() {

            if(!IsLibreTranslateServerRunning()) {

                if(libreTranslateServer == null) {

                    libreTranslateServer = new Process();
                    libreTranslateServer.StartInfo = new ProcessStartInfo("libretranslate") {
                        UseShellExecute = false
                    };
                }

                libreTranslateServer.Start();
            }

            if(!IsPykakasiServerRunning()) {

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

            if(IsLibreTranslateServerRunning())
                libreTranslateServer.CloseMainWindow();

            if(IsPykakasiServerRunning())
                pykakasiServer.CloseMainWindow();
        }

        public void RestartServer() {

            StopServer();
            StartServer();
        }
    }
}
