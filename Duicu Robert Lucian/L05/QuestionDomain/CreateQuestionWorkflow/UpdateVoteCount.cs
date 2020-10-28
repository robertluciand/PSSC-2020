using System;
using System.Linq;
using static QuestionDomain.CreateQuestionWorkflow.CreateQuestionResult;

namespace QuestionDomain.CreateQuestionWorkflow
{
    public class UpdateVoteCount
    {
        public QuestionCreated Update(QuestionCreated result, VoteCountEnum vote) 
        {
            var allVotes = result.allVotes.ToList();
            allVotes.Add(vote);

            return new QuestionCreated(result.Id, result.Title, result.Content, result.Tag, allVotes.Sum(nVotes => Convert.ToInt32(nVotes)), allVotes);
    }
}