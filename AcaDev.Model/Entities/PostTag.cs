﻿namespace AcaDev.Model.Entities
{
    public class PostTag
    {
        public Post Post { get; set; }
        public int PostId { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
