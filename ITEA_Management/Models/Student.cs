﻿using System;

        [DataType(DataType.Date), Display(Name = "Date of entry")]

        [Display(Name = "Current ID of course")]

        [ForeignKey("Course")]
        public int CurrentCourseId { get; set; }

    }