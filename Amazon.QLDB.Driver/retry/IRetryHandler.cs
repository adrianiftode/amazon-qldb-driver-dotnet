﻿/*
 * Copyright 2020 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use this file except in compliance with
 * the License. A copy of the License is located at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

namespace Amazon.QLDB.Driver
{
    using System;

    /// <summary>
    /// Interface of Retry Handler.
    /// </summary>
    internal interface IRetryHandler
    {
        /// <summary>
        /// Execute a retriable function.
        /// </summary>
        /// <typeparam name="T">The return type of the executed function.</typeparam>
        /// <param name="func">The function to be executed and retried if needed.</param>
        /// <param name="retryAction">The customer defined action to be executed on retry.</param>
        /// <param name="recoverAction">The extra internal recover action needed on certain retry cases.</param>
        /// <returns>The return value of the executed function.</returns>
        T RetriableExecute<T>(Func<T> func, Action<int> retryAction, Action recoverAction);
    }
}
