// Copyright 2024 SoftFuzz
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace ProfHeat.AUI.ViewModels;

public class BaseViewModel : ObservableObject
{
    protected static async Task HandleErrorAsync(Exception exception, string errorMessage = "An error occurred")
    {
        // Log the error
        Console.WriteLine($"{errorMessage}: {exception.Message}");

        // Show the user an error message
        _ = await MessageBoxManager
            .GetMessageBoxStandard("Error", $"{errorMessage}: {exception.Message}", ButtonEnum.Ok)
            .ShowAsync();
    }
}
