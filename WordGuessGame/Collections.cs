﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace WordGuessGame
{
    class Collections
    {
        public static IList<Question> programmingList = new List<Question>
            {
              new Question { questionID = 1, questionAnswer = "javascript", questionMessage = "Which programming language was developed by Brendan Eich, but was renamed in 1995?"},
              new Question { questionID = 2, questionAnswer = "inheritance", questionMessage = "In object-oriented programming, it refers to the ability of an object to take on one or more characteristics from other classes of objects"},
              new Question { questionID = 3, questionAnswer = "library", questionMessage ="It is a collection of files, programs, routines, scripts, or functions that can be referenced in the programming code"}
        };
        public static IList<Question> sovietSpaceList = new List<Question>
            {
               new Question { questionID = 1, questionAnswer = "gagarin", questionMessage = "Surname of the person, who was the first human that made a journey into outer space"},
               new Question { questionID = 2, questionAnswer = "korolyov", questionMessage = "Surname of the person, who made first successful launch of the first Soviet ballistic missile GIDR-10"},
               new Question { questionID = 3, questionAnswer = "strelka", questionMessage ="Name of the first dog that came back to Earth from the space by soviet space programm in 1960"}
        };
    }
}
