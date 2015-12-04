﻿using System;
using System.Threading.Tasks;
using Omise.Models;

namespace Omise.Resources {
    public interface IRetrievable<TModel>: IResource<TModel> where TModel: ModelBase {
    }

    public static class Retrievables {
        public static async Task<TResult> Get<TResult>(
            this IRetrievable<TResult> resource)
            where TResult: ModelBase {
            return await resource.Requester.Request<TResult>(
                resource.Endpoint,
                "GET",
                resource.BasePath
            );
        }
    }
}

