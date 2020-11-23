﻿using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPodcastRepository : IRepositoryBase<Podcast>
    {
        PagedList<Podcast> FindAll(QueryStringParameters parameters);

    }
}
