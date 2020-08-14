﻿using System.Collections.Generic;

namespace LearnAuthBlazor.Server.DTOs
{
    public class RegistrationResponseDto
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}