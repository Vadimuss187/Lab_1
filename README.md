# Лабораторная работа №1: Создание Activity и передача параметров между ними

- _Выполнил:_ Петухов
- _Язык программирования:_ Java

  ## Описание приложения
Приложение состоит из двух экранов. При нажатии на кнопку параметр с одного экрана передается на другой.

### Внешний вид
После запуска открывается экран 1 (`MainActivity`) с "Кнопка 1". По нажатию на кнопку происходит:
- Переход на экран 2 (`Activity2`)
- Передача параметра из `MainActivity` в переменную на экране `Activity2`
- Отображение текста "Переданный параметр: Петухов".

  <p align="center">
    <img src="https://github.com/Vadimuss187/Lab_1/blob/master/image%201.jpg" width="250"> 
    <img src="https://github.com/Vadimuss187/Lab_1/blob/master/image%202.jpg" width="250">
</p> 

## <a id="Как-собрать-проект">Как собрать проект?</a>
_Описан один из возможных способов:_
1. Скачиваем ZIP проекта.
2. Распаковываем загруженный архив.
3. Запускаем Android Studio.
4. Нажимаем  на "Open..." на начальном экране / в верхней панели File -> Open...
5. Выбираем распакованный архив.
6. Ждем завершения всех процессов внутри проекта.
7. Выбираем эмулятор или подключить реальное устройство.
8. Кликаем на "Run" (должна быть выбрана конфигурация "app").
9. Готово 
