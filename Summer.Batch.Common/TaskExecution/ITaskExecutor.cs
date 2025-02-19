﻿//
//   Copyright 2015 Blu Age Corporation - Plano, Texas
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

// This file has been modified.
// Original copyright notice :

/*
 * Copyright 2002-2012 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Threading.Tasks;

namespace Summer.Batch.Common.TaskExecution
{
    /// <summary>
    /// Simple task executor interface that abstracts the execution of a Task.
    /// Implementations can use all sorts of different execution strategies, such as: synchronous, asynchronous,
    /// using a thread pool, and more.
    /// </summary>
    public interface ITaskExecutor
    {
        /// <summary>
        /// Executes the given task.
        /// The call might return immediately if the implementation uses an asynchronous execution strategy, 
        /// or might block in the case of synchronous execution. 
        /// </summary>
        /// <param name="task">the Task to execute (never null).</param>
        /// <exception cref="TaskRejectedException">If the given task was not accepted.</exception>
        void Execute(Task task);
    }
}
