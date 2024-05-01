using CADLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADLib_Plugin_Kernel
{
    public class UI_PluginMenu_Handler
    {
        public UI_PluginMenu_Handler(PluginsManager pluginsManager)
        {
            CommonData.m_library = pluginsManager.Library;
            CommonData.m_mainForm = pluginsManager.MainForm;
            CommonData.m_mainDBBrowser = pluginsManager.MainDBBrowser;
        }
        #region Обработчики нажатия на кнопки
        public void Function_Handler_Hello()
        {
            MessageBox.Show("Hello, CADLib!");
        }

        public void Function_Handler_About()
        {
            var ass_info = Assembly.GetExecutingAssembly().GetName();
            MessageBox.Show("Версия плагина: " + ass_info.Version.ToString());
        }
        #endregion
    }
}
