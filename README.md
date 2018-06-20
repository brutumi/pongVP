# Понг - Визуелно
###### Изработен од: *Јован Јакимовски (163088), Бојан Јакимовски (163142)*

## 1. Опис на Апликацијата:
Апликацијата која ја избраме е Понг видео играта која е една од првите аркадни видео игри, и претставува пинг-понг со 2D графика.

Нашата имплементација на играта e различна, така што ние додадовме со секој нов погодок да се појавува ново топче во играта.

## 2. Упатство за користење
Играта се игра од двајца играчи на иста тастатура

#### *Контроли*

```       
        Играч 1		  Играч 2
	Горе – W	  Горе – Стрелка нагоре
	Доле – S	  Доле – Стрелка надоле
```
Резултатот e видлив на екранот, играта завршува кога некој од играчите ќе направи 50 поени.
## 3. Решение
### 3.1 Дизајн и имплементација
Формата е со фиксна големина, и опциите за зголемување се исклучени за да нема неправилности во играта ако се зголеми работната површина
### 3.2 Класи
Имаме 3 класи:

`Player` класата го чува резултатот за играчот, палката како PictureBox, брзината и неколку помошни променливи.

#### Метод ProcessMove

Методот има за задача да утврди дали ќе одиме горе или доле, исто така случајот кога притискаме и нагоре и надоле и земен во предвид и тогаш вредноста на променливата се става на null и не се движиме.
```
            bool? goingUp = null;
            if(isUpPressed) {
                goingUp = true;
            }

            if(isDownPressed) {
                if(goingUp.HasValue) {
                    // Не се движиме
                    goingUp = null;
                } else {
                    goingUp = false;
                }
            }

            DoMove(goingUp);
```
Тука се пресметува и забрзувањето на палката, така што секое тик од саатот проверуваме дали е притиснато копче и дали е во иста насока како претходното ако е тогаш ќе го зголемуваме забрзувањето.

```
        //ако има претходно
            if(wasGoingUpLastTick.HasValue) {
              // не се движи - ресет на променливата
                if(!goingUp.HasValue) {
                    wasGoingUpLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                }
              // иста насока - зголеми забрзување   
                else if(wasGoingUpLastTick.Value == goingUp.Value) {
                    numberOfTicksGoingInTheSameDirection++;
                }
              // нова насока - од почеток   
                else {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            }
            else if(goingUp.HasValue) {
                wasGoingUpLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }
```

#### Метод DoMove, ја пресметува новата брзина и новата локација на палката
```
private void DoMove(bool? goingUp) {
            if(goingUp.HasValue) {

            /* Новата брзина ја добиваме како математичка операција од брзината и од веќе пресметаното забрзување од претходно */

                var speed = (int)Math.Round(movementSpeed * ((float)numberOfTicksGoingInTheSameDirection / 10));

            //Ако се движиме нагоре брзината ја множи со -1

                if(goingUp.Value) {
                    speed *= -1;
                }

            }
        }
```

##### Новата локација, ограничување на палките, за да не се движат надвор од прозорецот.

Го ограничуваме така што ја споредува локацијата на долниот крај на формата : `PongWorldInfo.bottomOfWorld` , со новата локација : `paddle.Location.Y + speed` , и го бара минимумот од нив така што ако пробаме да одиме подоле нема да дозволи и ќе ја одбере крајната локација на формата : `PongWorldInfo.bottomOfWorld`, потоа ограничување од горната страна, треба да ја споредуваме најгорната позиција на формата : `PongWorldInfo.topOfWorld` чија вредност и 0, со новата позиција (која веќе е проверена и ограничена од доле) : `Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
, paddle.Location.Y + speed)`

```
            paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                        Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
                        , paddle.Location.Y + speed)
                        )
                    );
```
