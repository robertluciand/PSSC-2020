using LanguageExt.Common;
using static QuestionDomain.CreateQuestionWorkflow.QuestionData;


namespace QuestionDomain.CreateQuestionWorkflow
{
    public class VerificationQuestionData
    {
        public Result<VerifiedQuestion> VerifyQuestion(UnverifiedQuestion _question)
        {
            return new VerifiedQuestion(_question.Title, _question.Content, _question.Tag);
        }
    }
}