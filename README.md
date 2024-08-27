# HGames_APP

<a href="https://ibb.co/qnVs3nW"><img src="https://i.ibb.co/z5DRT57/321.png" alt="321" border="0"></a><br /><br />

![Static Badge](https://img.shields.io/badge/Framework-WPF_(Net_FrameWork_4.8)-purple?logo=dotnet) ![Static Badge](https://img.shields.io/badge/Language-C%23-purple?logo=csharp) ![Static Badge](https://img.shields.io/badge/DataBase-MSSQL-purple?logo=microsoftsqlserver)

## About

`HGames_APP` — это WPF-приложение, которое позволяет пользователям просматривать и искать игры, хранящиеся в базе данных, через API `HGamesAPI`. Приложение предоставляет удобный пользовательский интерфейс для работы с играми, отображая их название, описание, изображение и другие сведения.

### Основные функции

- **Просмотр списка игр**: Получение и отображение всех игр, доступных в базе данных.
- **Просмотр деталей игры**: Отображение подробной информации об игре, включая её изображение, описание и URL.

## Installation

1. Клонируйте репозиторий:

    ```bash
    git clone https://github.com/He11Cut3/HGames_APP.git
    ```

2. Перейдите в директорию проекта:

    ```bash
    cd HGames_APP
    ```

3. Установите зависимости:

    - Убедитесь, что у вас установлена SDK для .NET и необходимые библиотеки.
    - Используйте менеджер пакетов NuGet для установки необходимых пакетов, если они не установлены:

    ```bash
    dotnet add package Newtonsoft.Json
    dotnet add package RestSharp
    ```

4. Настройте файл `appsettings.json` или переменные среды для хранения URL API `HGamesAPI` и других необходимых настроек.

## Использование

1. Запустите приложение.
2. В главном окне будет отображен список всех игр из базы данных.
3. Используйте поле поиска для нахождения конкретной игры.
4. Нажмите на игру из списка для отображения подробной информации.

## Developers

- [He11Cut3](https://github.com/He11Cut3)
