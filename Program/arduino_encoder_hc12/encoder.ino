void bacaEncoder()
{
  stateA = digitalRead(faseA); // baca status awal dari fase A
  // kalo kondisi state fase A sekarang dan sebelumnya berbeda, berarti ada pulsa yang masuk guys
  if (stateA != stateAend) {
    // kalo state fase B berbeda dengan state fase A, berarti encoder berputar searah jarum jam
    if (digitalRead(faseB) != stateA) {
      counter ++;
    } else {
      counter --;
    }
   
  }
  stateAend = stateA; //update state dari fase
  panjang = counter*50/24000;

}
