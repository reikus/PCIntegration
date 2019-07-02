using System;
using System.IO;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using 

namespace PCHETZ
{
    /// <summary>
    /// our solidworks taskpane add-in
    /// </summary>
    public class TaskpaneIntegration : ISwAddin
    {
        #region private Members

        /// <summary>
        /// the cookie to the current instace of soliworks we are running
        /// </summary>

        private int mSwCookie;

        /// <summary>
        /// the taskpaneview for our add-in
        /// </summary>

        private TaskpaneView mTaskpaneView;

        /// <summary>
        /// the UI control that is going to be inside the solidworks taskpane view
        /// </summary>

        private TaskpaneHostUI mTaskpaneHost;

        /// <summary>
        /// the current instance of the solidworks application
        /// </summary>

        private SldWorks mSolidworksApplication;



        #endregion

        #region Public Members

        /// <summary>
        /// the unique Id to the TaskPane used for registration in com
        /// </summary>

        public const string SWTASKPANE_PROGID = "PCHETZ";

        #endregion

        #region Solidworks Add-in Callbacks
        /// <summary>
        /// called when solidworks has loaded our Add-in and wants as to do our connection logic
        /// </summary>
        /// <param name="ThisSW">the current solidworks instance</param>
        /// <param name="Cookie">the current solidworks cookie ID</param>
        /// <returns></returns>

        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            //store a reference to the current solidworks instance
            mSolidworksApplication = (SldWorks)ThisSW;
            //store cookie Id
            mSwCookie = Cookie;
            //setup callback info
            var ok = mSolidworksApplication.SetAddinCallbackInfo2(0, this, mSwCookie);
            //Create our UI
            LoadUI();
            //Return ok
            return true;
        }

        /// <summary>
        /// called when solidworks is about to unload our Add-in and wants as to do our disconnection logic
        /// </summary>

        public bool DisconnectFromSW()
        {
            //Clean up our UI
            UnloadUI();
            //Return ok
            return true;
        }


        #endregion

        #region Create UI

        /// <summary>
        /// Create our taskpane and inject our host UI 
        /// </summary>

        private void LoadUI()
        {
            var imagePath = Path.Combine(Path.GetDirectoryName(typeof(TaskpaneIntegration).Assembly.CodeBase).Replace(@"file:\", string.Empty), "Logo.png");

               //create our taskpane
                  mTaskpaneView = mSolidworksApplication.CreateTaskpaneView2(imagePath, "אוטומציה פיסיחץ");

            //load our UI into the taskpane
            mTaskpaneHost = (TaskpaneHostUI)mTaskpaneView.AddControl(TaskpaneIntegration.SWTASKPANE_PROGID, string.Empty);
                
                }

        /// <summary>
        /// Cleanup the taskpane whene we dinconnct/unload
        /// </summary>

        private void UnloadUI()
        {
            mTaskpaneHost = null;

            //remove taskpane view
            mTaskpaneView.DeleteView();

            //release com reference and cleanup memory
            Marshal.ReleaseComObject(mTaskpaneView);

            mTaskpaneView = null;
        }

        #endregion

        #region COM Registration
        /// <summary>
        /// The com registration call to add our registry entries to the solidworks Add-in registry
        /// </summary>
        /// <param name="t"></param>
        [ComRegisterFunction()]
        private static void ComRegister(Type t)
        {
            var KeyPath = string.Format(@"SOFTWARE\SolidWorks\Addins\{0:b}", t.GUID);

            //create our registry folder for the add-in 
            using (var rk = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(KeyPath))
            {
                //load addin when solidworks open
                rk.SetValue(null, 1);
                //set solidworks add-in title and description
                rk.SetValue("Title", "my SwAddin");
                rk.SetValue("Description", "let make DXF'S!");

            }
        }
        /// <summary>
        ///The com unregister call to remove our custom entries we added in the custom 
        /// </summary>
        /// <param name="t"></param>
        [ComUnregisterFunction()]
        private static void ComUnregister(Type t)
        {
            var KeyPath = string.Format(@"SOFTWARE\SolidWorks\Addins\{0:b}", t.GUID);

            //Remove our registry entry 
            Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(KeyPath);

        }
        #endregion

    }
}
