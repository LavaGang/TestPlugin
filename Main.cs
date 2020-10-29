using MelonLoader;

namespace TestPlugin
{
    public static class BuildInfo
    {
        public const string Name = "TestPlugin"; // Name of the Plugin.  (MUST BE SET)
        public const string Description = "Plugin for Testing"; // Description for the Plugin.  (Set as null if none)
        public const string Author = "TestAuthor"; // Author of the Plugin.  (MUST BE SET)
        public const string Company = null; // Company that made the Plugin.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Plugin.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Plugin.  (Set as null if none)
    }

    public class TestPlugin : MelonPlugin
    {
        public override void OnPreInitialization() // Runs before Game Initialization.
        {
            MelonLogger.Msg("OnPreInitialization");
        }

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("OnApplicationStart");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved to file.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }
    }
}