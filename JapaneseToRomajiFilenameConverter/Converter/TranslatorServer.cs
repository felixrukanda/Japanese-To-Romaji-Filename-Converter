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

        bool IsLibreTranslateServerRunning() {

            return libreTranslateServer != null && !libreTranslateServer.HasExited;
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
        }

        public void StopServer() {

            if(IsLibreTranslateServerRunning())
                libreTranslateServer.CloseMainWindow();
        }

        public void RestartServer() {

            StopServer();
            StartServer();
        }
    }
}
