﻿namespace StudyPlatform.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        
        public DateTime? CreatedDate { get; set; }
        public DateTime FinishiDate { get; set; }
    }
}
