using System.ComponentModel;

namespace JBPI.Log
{
    public static class LogAPI
    {
        // 默认情况下的日志
        [Description("这是常用的日志，您可以直接使用")]
        public static void 日志(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.Cyan);

        // 警告日志
        [Description("这是当设置警告的日志，如操作者正在进行意料之外的操作")]
        public static void 警告(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.DarkYellow);

        // 调式日志 Debug
        [Description("调试用日志，您需要自己书写一个判定自己的配置文件的Debug有没有开启")]
        public static void 调试(string 消息)
            => ServerConsole.AddLog($"[调试] {消息}", System.ConsoleColor.Gray);

        // 发生错误时的日志
        [Description("这是用于错误的日志，它是红色的！")]
        public static void 错误(string 消息)
            => ServerConsole.AddLog($"[错误] {消息}", System.ConsoleColor.Red);

        // 其他日志
        [Description("该日志用于没有想好该发送一个怎样的日志时使用")]
        public static void 其他(string 消息)
            => ServerConsole.AddLog(消息, System.ConsoleColor.Green);

        // 自定义消息
        [Description("自定义! 您可以自定义该日志的颜色!")]
        public static void 自定义(string 消息, System.ConsoleColor 颜色)
            => ServerConsole.AddLog(消息, 颜色);
    }
}
