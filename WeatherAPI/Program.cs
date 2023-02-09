using Newtonsoft.Json;
using System;
using System.Net.Http;
using WeatherAPI;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var apiKey = "de652bea5fc39e262e384811c44b47a7";
var client = new HttpClient();
Console.WriteLine("Введите город");
var cityUser = Console.ReadLine();
var response2 = await client.GetAsync(
    $"https://api.openweathermap.org/data/2.5/forecast?q={cityUser}&appid={apiKey}&units=metric&lang=ru");

if (response2.IsSuccessStatusCode)
{  
    DateTime doWeek;
    int u = 0;
    var result2 = await response2.Content.ReadAsStringAsync();
    var model = JsonConvert.DeserializeObject<WeatherFor4Days>(result2);
    Console.WriteLine($"{model.city.name}, {model.city.country}, {DateTime.Now}\n" +
            $"Погодные условия: {model.list[0].weather[0].description}\n" +
            $"Температура воздуха: {model.list[0].main.temp}°С, ощущается как {model.list[0].main.feels_like}°С\n" +
            $"Скорость ветра: {model.list[0].wind.speed}м/с\n" +
            $"Давление: {model.list[0].main.grnd_level} мм рт. ст.\n" +
            $"Влажность: {model.list[0].main.humidity}%" +
            $"--------Прогноз на 4 дня----------\n");
    Console.WriteLine("\tДата и день     \t | Макс и мин. * \t | Описание");
     for (int i = 1; i < 5; i++){
        Console.WriteLine($"\t{DateTime.Parse(model.list[u].dt_txt).ToShortDateString()}, {DateTime.Parse(model.list[u].dt_txt).DayOfWeek} \t | {model.list[i].main.temp_min}, {model.list[i].main.temp_max} \t | {model.list[i].weather[0].description}");
        u += 8;}
}


