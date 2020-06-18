using System.Windows.Forms;

namespace Art2MSpell.Classes
{
    /// <summary>Create message boxes.</summary>
    public static class MyMessagesClass
    {
        /// <summary>
        ///     The error message to be displayed.
        /// </summary>
        public static string ErrorMessage { get; set; }

        /// <summary>
        ///     The information message to be displayed.
        /// </summary>
        public static string InformationMessage { get; set; }

        /// <summary>
        ///     Contains the name of the class where the message box was called from.
        /// </summary>
        public static string NameOfClass { get; set; }

        /// <summary>
        ///     Contains the name of the method where the message box is called from.
        /// </summary>
        public static string NameOfMethod { get; set; }

        /// <summary>
        ///     Contains the question to ask the user.
        /// </summary>
        public static string QuestionMessage { get; set; }

        /// <summary>
        ///     Contains the warning message to be displayed.
        /// </summary>
        public static string WarningMessage { get; set; }

        /// <summary>
        ///     Shows the error message.
        /// </summary>
        /// <param name="msg">The error message to be displayed.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void ShowErrorMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Display error message box with message, class name and method name.
        /// </summary>
        /// <param name="msg">The error message to be displayed.</param>
        /// <param name="className">The class name.</param>
        /// <param name="methodName">The method name.</param>
        public static void ShowErrorMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Display error message box with class name, method name and message.
        /// </summary>
        public static void ShowErrorMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(NameOfClass, ": ");
            location = string.Concat(location, NameOfMethod);
            MessageBox.Show(ErrorMessage, location, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Shows the information message.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        public static void ShowInformationMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Shows the information message box.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="className">The name of the class.</param>
        /// <param name="methodName">The name of the method.</param>
        public static void ShowInformationMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Display information message box with method name and message.
        /// </summary>
        public static void ShowInformationMessageBox()
        {
            var location = string.Concat(NameOfClass, ":  ");
            location = string.Concat(location, NameOfMethod);

            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(InformationMessage, location, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Shows the question message.
        /// </summary>
        /// <param name="msg">The question message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns>yes or no answer to the question.</returns>
        public static DialogResult ShowQuestionMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        ///     Display question message box with method name and message.
        /// </summary>
        /// <returns>Return yes or no answer to the question.</returns>
        public static DialogResult ShowQuestionMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(QuestionMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        ///     Shows the warning message.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        public static void ShowWarningMessage(string msg, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Shows the warning message box.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        public static void ShowWarningMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, MsgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Display warning message box with method name and message.
        /// </summary>
        public static void ShowWarningMessageBox()
        {
            const MessageBoxButtons MsgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(WarningMessage, NameOfMethod, MsgboxButtons, MessageBoxIcon.Warning);
        }
    }
}