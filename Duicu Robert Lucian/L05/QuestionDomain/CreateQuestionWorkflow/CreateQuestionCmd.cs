using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionDomain.CreateQuestionWorkflow
{
    public struct CreateQuestionCmd
    {
        [Required]
        public string Title { get; private set; }
        [Required]
        public string Content { get; private set; }
        [Required]
        public List<string> Tag { get; private set; }

        public CreateQuestionCmd(string Title, string Content, List<string> Tag)
        {
            this.Title = Title;
            this.Content = Content;
            this.Tag = Tag;
        }
    }
}