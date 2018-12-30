
int tak (int x, int y, int z) {
  if (!(y < x)) {
    return z;
  }
  else {
    return tak ( tak((x-1), y, z), tak((y-1), z, x), tak((z-1), x, y));
  }
}

void setup() {
  Serial.begin(115200);
  Serial.println("Starting...");
}

int result;
uint32_t startTime;
uint32_t stopTime;
void loop() {
  Serial.flush();
  startTime=micros();
  result = tak(18,12,6);
  stopTime=micros();
  Serial.print("tak(18,12,6)=");
  Serial.println(result);
  Serial.print("Time=");
  Serial.print(stopTime-startTime);
  Serial.println(" useconds.");
}