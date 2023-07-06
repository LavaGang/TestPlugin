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

        public override void OnApplicationEarlyStart() // Runs after Game Initialization, before OnApplicationStart and (on Il2Cpp games) before Unhollower.
        {
            MelonLogger.Msg("OnApplicationEarlyStart");
        }

        public override void OnInitializeMelon() // Runs after Game Initialization.
        {
            MelonLogger.Msg("OnInitializeMelon / OnApplicationStart");
        }

        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnLateInitializeMelon / OnApplicationLateStart");
        }

        public override void OnUpdate() // Runs once per frame.
        {
            MelonLogger.Msg("OnUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
    }
}