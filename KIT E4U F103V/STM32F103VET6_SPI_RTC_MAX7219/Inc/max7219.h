#ifndef MAX7219_H_
#define MAX7219_H_

#include "stm32f1xx_hal.h"
#include "main.h"

void Send_SPI1(uint8_t rg, uint8_t dt);
void Clear_SPI1 (void);
void Number_SPI1 (volatile long n);
void Init_SPI1 (void);

void Send_SPI2(uint8_t rg, uint8_t dt);
void Clear_SPI2 (void);
void Number_SPI2 (volatile long n);
void Init_SPI2 (void);
#endif /* MAX7219_H_ */
