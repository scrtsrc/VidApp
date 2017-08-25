﻿using System;
using VidAppBLL.Services;

namespace VidAppBLL
{
    public class BLLFacade
    {
		//Making a method that returns the service
		public IVidService GetVidService()
        {
            return new VideoService();
        }

        //Making a property
        public IVidService VidService
        {
            get
            {
                return new VideoService();
            }
        }
    }
}