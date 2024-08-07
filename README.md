﻿# Hangman

<h2> Виселица (также «Балда») </h2> — игра на бумаге для двух (или больше) человек
<h2>Используемые технологии:</h2>
<ul>
<li>C#</li>
</ul>
<h2>Функционал приложения и меню консольного интерфейса:</h2>
<ol>
<li>При старте, приложение предлагает начать новую игру или выйти из приложения
<li>При начале новой игры, случайным образом загадывается слово, и игрок начинает процесс по его отгадыванию
<li>После каждой введенной буквы выводим в консоль счётчик ошибок, текущее состояние виселицы (нарисованное ASCII символами)
<li>По завершении игры выводим результат (победа или поражение) и возвращаемся к состоянию #1 - предложение начать новую игру или выйти из приложения
</ol>
<img src="prev_image/preview.jpg">
<h2>Принцип игры:</h2>
Один из игроков загадывает слово — пишет на бумаге любые две буквы слова и отмечает места для остальных букв, например чертами (существует также вариант, когда изначально все буквы слова неизвестны). Также рисуется виселица с петлёй.

Согласно традиции русских лингвистических игр, слово должно быть именем существительным, нарицательным в именительном падеже единственного числа, либо множественного числа при отсутствии у слова формы единственного числа.

Второй игрок предлагает букву, которая может входить в это слово. Если такая буква есть в слове, то первый игрок пишет её над соответствующими этой букве чертами — столько раз, сколько она встречается в слове. Если такой буквы нет, то к виселице добавляется круг в петле, изображающий голову. Второй игрок продолжает отгадывать буквы до тех пор, пока не отгадает всё слово. За каждый неправильный ответ первый игрок добавляет одну часть туловища к виселице (обычно их 6: голова, туловище, 2 руки и 2 ноги, существует также вариант с 8 частями — добавляются ступни, а также самый длинный вариант, когда сначала за неотгаданную букву рисуются части самой виселицы).

Если туловище в виселице нарисовано полностью, то отгадывающий игрок проигрывает, считается повешенным. Если игроку удаётся угадать слово, он выигрывает и может загадывать слово.
