// Определение делегатов
using Example02;

Message message1 = Welcome.Print;
Message message2 = new Hello().Display;

message1();
message2();

delegate void Message();
