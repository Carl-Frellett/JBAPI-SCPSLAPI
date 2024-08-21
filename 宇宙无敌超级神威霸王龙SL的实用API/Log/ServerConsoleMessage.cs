using Exiled.API.Features;

namespace JBPI.Log
{
    public static class ServerCC
    {
        // 默认情况下的日志
        public static void 日志(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.Cyan);

        // 警告日志
        public static void 警告(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.DarkYellow);

        // 调式日志 Debug
        public static void 调试(string 消息)
            => Exiled.API.Features.Log.Debug(消息);

        // 发生错误时的日志
        public static void 错误(string 消息)
            => ServerConsole.AddLog($"[错误] {消息}", System.ConsoleColor.Red);

        // 其他日志
        public static void 其他(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.Green);

        // 自定义消息
        public static void 自定义(string 消息, System.ConsoleColor 颜色)
            => ServerConsole.AddLog(消息, 颜色);
    }
}
