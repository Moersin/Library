﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Iss
    {
        private int issId = 0;
        private int issBookId = 0;
        private string issBookName = string.Empty;
        private int issUserId = 0;
        private DateTime issBeginTime = new DateTime(2000,01,01);
        private DateTime issEndTime = new DateTime(3000,01,01);

        public int IssId { get => issId; set => issId = value; }
        public int IssBookId { get => issBookId; set => issBookId = value; }
        public string IssBookName { get => issBookName; set => issBookName = value; }
        public int IssUserId { get => issUserId; set => issUserId = value; }
        public DateTime IssBeginTime { get => issBeginTime; set => issBeginTime = value; }
        public DateTime IssEndTime { get => issEndTime; set => issEndTime = value; }
    }
}