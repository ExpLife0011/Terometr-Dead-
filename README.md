# TeraDpsMeter
ДПСметер для игры TERA Online

Пока готов только снифер, потестил: примерно 600000 пакетов, примерно 50000 ошибок обработано, ни одного потеряного тера-пакета.
Позже сделаю GUI для снифера

Для работы нужен WinpkFilter 3.2.3, http://www.ntkernel.com/?Products:Development_Toolkits:Windows_Packet_Filter_Kit

Почему не pcap? У pcap'a 5% потеря пакетов, а для расшифровки пакетов теры нужен весь поток данных.

По поводу самого ДПС метра, доделаю как будет время.

Путь: 

-> Сделать GUI - 85%(100%)
    Впринцепи ГУИ готов, может будут небольшие изменения касательно кнопочек: поиск, добавить в чёрный список, добавить в белый список и др. полезные кнопки.

-> Сделать возможность просмотра содержимого пакета - (2/ushort.max * 100) %
    Сейчас парсятся только 2 пакета, остальными мне заниматься не хочется, я всёже пишу ДПС метр а не снифер.

-> Продумать ДПС метр 0%
    Было бы неплохо иметь представление, что нужно мне для ДПС метра.

-> Расшифровать пакеты необходимые для ДПС метра

-> Написать ДПС метр
