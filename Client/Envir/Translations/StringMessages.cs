using Library;

namespace Client.Envir.Translations
{
    public abstract class StringMessages
    {
        [ConfigSection("LoginScene")]
        public abstract string Login { get; set; }
        public abstract string Account { get; set; }
        public abstract string EMail { get; set; }
        public abstract string Password { get; set; }
        public abstract string EMailHelp { get; set; }
        public abstract string PasswordHelp { get; set; }
        public abstract string Remember { get; set; }
        public abstract string LoginBtn { get; set; }
        public abstract string ChangePassword { get; set; }
        public abstract string ForgotPassword { get; set; }
        public abstract string NewAccount { get; set; }
        public abstract string AccountCreation { get; set; }
        public abstract string Cancel { get; set; }
        public abstract string Create { get; set; }
        public abstract string RealName { get; set; }
        public abstract string BirthDate { get; set; }
        public abstract string Referral { get; set; }
        public abstract string RealNameHelp { get; set; }
        public abstract string BirthDateHelp { get; set; }
        public abstract string ReferralHelp { get; set; }
        public abstract string Change { get; set; }
        public abstract string CurrentPassword { get; set; }
        public abstract string NewPassword { get; set; }
        public abstract string RequestPasswordReset { get; set; }
        public abstract string Request { get; set; }
        public abstract string HaveResetKey { get; set; }
        public abstract string ResetPassword { get; set; }
        public abstract string Reset { get; set; }
        public abstract string ResetKey { get; set; }
        public abstract string ResetHelp { get; set; }
        public abstract string AccountActivation { get; set; }
        public abstract string Activate { get; set; }
        public abstract string ActivationKey { get; set; }
        public abstract string ActivationHelp { get; set; }
        public abstract string EMailResend { get; set; }
        public abstract string RequestActivationKey { get; set; }

        [ConfigSection("ConfigWin")]
        public abstract string Configuration { get; set; }
        public abstract string Graphics { get; set; }
        public abstract string Sound { get; set; }
        public abstract string Game { get; set; }
        public abstract string Network { get; set; }
        public abstract string Colours { get; set; }
        public abstract string FullScreen { get; set; }
        public abstract string GameSize { get; set; }
        public abstract string VSync { get; set; }
        public abstract string LimitFPS { get; set; }
        public abstract string ClipMouse { get; set; }
        public abstract string DebugLabel { get; set; }
        public abstract string Language { get; set; }
        public abstract string BackgroundSound { get; set; }
        public abstract string SystemVolume { get; set; }
        public abstract string MusicVolume { get; set; }
        public abstract string PlayerVolume { get; set; }
        public abstract string MonsterVolume { get; set; }
        public abstract string MagicVolume { get; set; }
        public abstract string ItemName { get; set; }
        public abstract string MonsterName { get; set; }
        public abstract string PlayerName { get; set; }
        public abstract string UserHealth { get; set; }
        public abstract string MonsterHealth { get; set; }
        public abstract string DamageNumbers { get; set; }
        public abstract string EscapeCloseAll { get; set; }
        public abstract string ShiftOpenChat { get; set; }
        public abstract string ShiftOpenChatHt { get; set; }
        public abstract string RightClickDeTarget { get; set; }
        public abstract string RightClickDeTargetHt { get; set; }
        public abstract string MonsterBoxVisible { get; set; }
        public abstract string LogChat { get; set; }
        public abstract string DrawEffects { get; set; }
        public abstract string KeyBind { get; set; }
        public abstract string UseNetworkConfig { get; set; }
        public abstract string IPAddress { get; set; }
        public abstract string Port { get; set; }
        public abstract string LocalChat { get; set; }
        public abstract string GMWhisperIn { get; set; }
        public abstract string WhisperIn { get; set; }
        public abstract string WhisperOut { get; set; }
        public abstract string GroupChat { get; set; }
        public abstract string GuildChat { get; set; }
        public abstract string ShoutChat { get; set; }
        public abstract string GlobalChat { get; set; }
        public abstract string ObserverChat { get; set; }
        public abstract string HintText { get; set; }
        public abstract string SystemText { get; set; }
        public abstract string GainsText { get; set; }
        public abstract string Announcements { get; set; }
        public abstract string ResetAll { get; set; }
        public abstract string Apply { get; set; }
        public abstract string Exit { get; set; }

        [ConfigSection("AssistSetting")]
        public abstract string AssistSet { get; set; }
        public abstract string AutoPotion { get; set; }
        public abstract string CombatAssist { get; set; }
        public abstract string Health { get; set; }
        public abstract string Mana { get; set; }
        public abstract string Enabled { get; set; }
        public abstract string AutomaticSkill { get; set; }
    }
}
