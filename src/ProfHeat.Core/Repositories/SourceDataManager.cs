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

using ProfHeat.Core.Interfaces;
using ProfHeat.Core.Models;

namespace ProfHeat.Core.Repositories;

public class SourceDataManager(IRepository repository) : ISourceDataManager
{
    public List<MarketCondition> LoadSourceData(string filePath) => repository.Load<List<MarketCondition>>(filePath).ToList();

    public void SaveSourceData(List<MarketCondition> data, string filePath) => repository.Save(data, filePath);

    public List<MarketCondition> FetchData(DateTime from, DateTime to) =>
    repository.Load<List<MarketCondition>>($"https://api.energidataservice.dk/dataset/Elspotprices?start={from:yyyy-MM-dd}&end={to:yyyy-MM-dd}");
}
