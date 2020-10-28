using System.Collections.Generic;
using LanguageExt.Common;


namespace QuestionDomain.CreateQuestionWorkflow
{
    [AsChoice]
    public partial class QuestionData
    {
        public interface IQuestionData
        {

        }
        public class UnverifiedQuestion : IQuestionData
        {
            public string Title { get; private set; }
            public string Content { get; private set; }
            public List<string> Tag { get; private set; }

            private UnverifiedQuestion(string title, string Content, List<string> tag)
            {
                this.Title = title;
                this.Content = Content;
                this.Tag = tag;
            }

            public static Result<UnverifiedQuestion> Create(string title, string Content, List<string> tag)
            {
                if (IsQuestionDataValid(title, Content, tag))
                {
                    return new UnverifiedQuestion(title, Content, tag);
                }
                else
                {
                    return new Result<UnverifiedQuestion>(new InvalidQuestionDataException(title, Content, tag));
                }
            }

            private static bool IsQuestionDataValid(string title, string Content, List<string> tag)
            {
                if (Content.Length < 1000 && tag.Count >= 1 && tag.Count <= 3)
                {
                    return true;
                }
                return false;
            }
        }
        public class VerifiedQuestion : IQuestionData
        {
            public string Title { get; private set; }
            public string Content { get; private set; }
            public List<string> Tag { get; private set; }

            internal VerifiedQuestion(string title, string Content, List<string> tag)
            {
                this.Title = title;
                this.Content = Content;
                this.Tag = tag;
            }
        }
    }
}