using System;
using System.Collections.Generic;
using Microsoft.CSharp.Choices;

namespace QuestionDomain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class CreateQuestionResult
    {
        public interface ICreateQuestionResult { }

        public class QuestionCreated : ICreateQuestionResult
        {
            public Guid Id { get; private set; }
            public string Title { get; private set; }
            public string Content { get; private set; }
            public List<string> Tag { get; private set; }
            public int VoteCount { get; private set; }
            public IReadOnlyCollection<VoteCountEnum> allVotes { get; private set; }
            public QuestionCreated(Guid Id, string Titlu, string Content, List<string> tag, int voteCount, IReadOnlyCollection<VoteCountEnum> allVotes)
            {
                this.Title = Title;
                this.Content = Content;
                this.Id = Id;
                this.VoteCount = VoteCount;
                this.allVotes = allVotes;
            }
        }

        public class QuestionNotCreated : ICreateQuestionResult
        {
            public string sendError { get; set; }

            public QuestionNotCreated(string sendError)
            {
                this.sendError = sendError;
            }
        }

        public class QuestionValidationFailed : ICreateQuestionResult
        {
            public List<string> ValidationError { get; set; }

            public QuestionValidationFailed(List<string> Error)
            {
                ValidationError = Error;
            }
        }
    }
}