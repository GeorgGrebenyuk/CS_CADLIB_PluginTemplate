using CADLib;
using CADLib_Plugin_UI;

namespace CADLib_PluginTemplate
{
    public class CADLibPluginEntryPoint
    {
        /// <summary>
        /// Статический метод регистрации плагин, вызываемый родительским приложением
        /// </summary>
        /// <param name="manager">Объект текущего окружения плагина</param>
        /// <returns>Интерфейс плагина</returns>
        public static ICADLibPlugin RegisterPlugin(PluginsManager manager)
        {
            //check autorization
            return new UI_PluginStart(manager);
        }

    }
}
