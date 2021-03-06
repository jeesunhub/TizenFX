/*
 *  Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License
 */

using Xamarin.Forms;
using Tizen;
using Tizen.System;
using Tizen.Tapi;

namespace XamarinForTizen.Tizen
{
    internal class Globals
    {
        internal static string LogTag = "Tapitest";

        internal static TapiHandle handleModem0 = null;
        internal static TapiHandle handleModem1 = null;
    }
    public class App : Application
    {
        private static bool s_isTapiSupported = false;
        public App()
        {
            SystemInfo.TryGetValue("http://tizen.org/feature/network.telephony", out s_isTapiSupported);
            if (s_isTapiSupported)
            {
                Log.Debug(Globals.LogTag, "tapi feature check = " + s_isTapiSupported);
                MainPage = new NavigationPage(new MainPage());
            }

            else
            {
                Log.Debug(Globals.LogTag, "tapi feature is not supported");
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        private static App _app;
        protected override void OnCreate()
        {
            base.OnCreate();

            Log.Debug(Globals.LogTag, "OnCreate()");
            _app = new App();
            LoadApplication(_app);
        }

        public static App getApp()
        {
            return _app;
        }
        static void Main(string[] args)
        {
            Log.Debug(Globals.LogTag, "inside main");
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }
}