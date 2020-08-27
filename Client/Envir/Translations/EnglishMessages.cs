using Library;

namespace Client.Envir.Translations
{
    [ConfigPath(@".\Translations\EnglishMessages.ini")]
    public class EnglishMessages : StringMessages
    {
        public override string Login { get; set; } = "Login";
        public override string Account { get; set; } = "Account:";
        public override string EMail { get; set; } = "E-Mail:";
        public override string Password { get; set; } = "Password:";
        public override string EMailHelp { get; set; } = "E-Mail Address.\nFormat: Example@Example.Com.\nMax Length: {0} characters.";
        public override string PasswordHelp { get; set; } = "Password.\nAccepted characters:Any non-white space character.\nLength: between {0} and {1} characters.";
        public override string Remember { get; set; } = "Remember Detaails";
        public override string LoginBtn { get; set; } = "Log In";
        public override string ChangePassword { get; set; } = "Change Password";
        public override string ForgotPassword { get; set; } = "Forgeot Password ?";
        public override string NewAccount { get; set; } = "Create New Account";
        public override string AccountCreation { get; set; } = "Account Creation";
        public override string Cancel { get; set; } = "Cancel";
        public override string Create { get; set; } = "Create";
        public override string RealName { get; set; } = "Real Name:";
        public override string BirthDate { get; set; } = "Birth Date:";
        public override string Referral { get; set; } = "Referral:";
        public override string RealNameHelp { get; set; } = "Real Name.\nAccepted characters: All.\nLength: between {0} and {1} characters.\nRequired: {2}.";
        public override string BirthDateHelp { get; set; } = "Birth Date.\nFormat: {0}.\nRequired: {0}.";
        public override string ReferralHelp { get; set; } = "E-Mail Address of the person who referred you.\nFormat: Example@Example.Com.\nMax Length: {0} characters.";
        public override string Change { get; set; } = "Change";
        public override string CurrentPassword { get; set; } = "Current Password:";
        public override string NewPassword { get; set; } = "New Password:";
        public override string RequestPasswordReset { get; set; } = "Request Password Reset";
        public override string Request { get; set; } = "Request";
        public override string HaveResetKey { get; set; } = "Have Reset Key?";
        public override string ResetPassword { get; set; } = "Reset Password";
        public override string Reset { get; set; } = "Reset";
        public override string ResetKey { get; set; } = "Reset Key:";
        public override string ResetHelp { get; set; } = "Reset Key.\nRandom series of numbers and letters found in the password reset E-Mail.\nCase Sensetive.";
        public override string AccountActivation { get; set; } = "Account Activation";
        public override string Activate { get; set; } = "Activate";
        public override string ActivationKey { get; set; } = "Activation Key:";
        public override string ActivationHelp { get; set; } = "Activation Key.\nRandom series of numbers and letters found in the activation E-Mail.\nCase Sensetive.";
        public override string EMailResend { get; set; } = "Not received E-Mail?";
        public override string RequestActivationKey { get; set; } = "Request Activation Key";

        public override string Configuration { get; set; } = "Configuration";
        public override string Graphics { get; set; } = "Graphics";
        public override string Sound { get; set; } = "Sound";
        public override string Game { get; set; } = "Game";
        public override string Network { get; set; } = "Network";
        public override string Colours { get; set; } = "Colours";
        public override string FullScreen { get; set; } = "Full Screen:";
        public override string GameSize { get; set; } = "Game Size:";
        public override string VSync { get; set; } = "V-Sync:";
        public override string LimitFPS { get; set; } = "Limit FPS:";
        public override string ClipMouse { get; set; } = "Clip Mouse:";
        public override string DebugLabel { get; set; } = "Debug Label:";
        public override string Language { get; set; } = "Language:";
        public override string BackgroundSound { get; set; } = "Background Sound:";
        public override string SystemVolume { get; set; } = "System Volume:";
        public override string MusicVolume { get; set; } = "Music Volume:";
        public override string PlayerVolume { get; set; } = "Player Volume:";
        public override string MonsterVolume { get; set; } = "Monster Volume:";
        public override string MagicVolume { get; set; } = "Magic Volume:";
        public override string ItemName { get; set; } = "Item Names:";
        public override string MonsterName { get; set; } = "Monster Names:";
        public override string PlayerName { get; set; } = "Player Name:";
        public override string UserHealth { get; set; } = "User Health:";
        public override string MonsterHealth { get; set; } = "Monster Health:";
        public override string DamageNumbers { get; set; } = "Damage Numbers:";
        public override string EscapeCloseAll { get; set; } = "Escape Close All:";
        public override string ShiftOpenChat { get; set; } = "Shift + 1  Open Chat:";
        public override string ShiftOpenChatHt { get; set; } = "If turned on, Pressing Shift + 1 will open chat, if this is off you will use Quick Slot 1";
        public override string RightClickDeTarget { get; set; } = "Right Click De-Target:";
        public override string RightClickDeTargetHt { get; set; } = "If turned on, Right clicking to move away will also remove monster target.";
        public override string MonsterBoxVisible { get; set; } = "Show Monster Info:";
        public override string LogChat { get; set; } = "Log Chat:";
        public override string DrawEffects { get; set; } = "Draw Effects:";
        public override string KeyBind { get; set; } = "Key Binds";
        public override string UseNetworkConfig { get; set; } = "Use Config:";
        public override string IPAddress { get; set; } = "IP Address:";
        public override string Port { get; set; } = "Port:";
        public override string LocalChat { get; set; } = "Local Chat:";
        public override string GMWhisperIn { get; set; } = "GM Whisper In:";
        public override string WhisperIn { get; set; } = "Whisper In:";
        public override string WhisperOut { get; set; } = "Whisper Out:";
        public override string GroupChat { get; set; } = "Group Chat:";
        public override string GuildChat { get; set; } = "Guild Chat:";
        public override string ShoutChat { get; set; } = "Shout Chat:";
        public override string GlobalChat { get; set; } = "Global Chat:";
        public override string ObserverChat { get; set; } = "Observer Chat:";
        public override string HintText { get; set; } = "Hint Text:";
        public override string SystemText { get; set; } = "System Text:";
        public override string GainsText { get; set; } = "Gains Text:";
        public override string Announcements { get; set; } = "Announcements:";
        public override string ResetAll { get; set; } = "Reset All";
        public override string Apply { get; set; } = "Apply";
        public override string Exit { get; set; } = "Exit";

        public override string AssistSet { get; set; } = "AssistSetting";
        public override string AutoPotion { get; set; } = "Auto Potion";
        public override string CombatAssist { get; set; } = "Combat Assist";
        public override string Health { get; set; } = "Health";
        public override string Mana { get; set; } = "Mana";
        public override string Enabled { get; set; } = "Enabled";
        public override string AutomaticSkill { get; set; } = "Automatic Skill";
    }
}
