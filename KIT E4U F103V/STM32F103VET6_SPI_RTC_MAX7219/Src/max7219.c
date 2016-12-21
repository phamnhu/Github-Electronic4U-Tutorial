#include "stm32f1xx_hal.h"
uint8_t Buf_SPI1[1] = {0}, Buf_SPI2[1] = {0};
extern SPI_HandleTypeDef hspi1; 		//Sec, Min, Hour
extern SPI_HandleTypeDef hspi2;			// Day, Date, Month, Year
char dg = 8;

#define SPI1_Enable		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4, GPIO_PIN_RESET)
#define SPI1_Disable 	HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4, GPIO_PIN_SET)


void Send_SPI1 (uint8_t rg, uint8_t dt)
{
	SPI1_Enable;
	Buf_SPI1[0] = rg;
	HAL_SPI_Transmit (&hspi1, (uint8_t*)Buf_SPI1, 1, 1000);
	Buf_SPI1[0] = dt;
	HAL_SPI_Transmit (&hspi1, (uint8_t*)Buf_SPI1, 1, 1000);
	SPI1_Disable;
}
void Clear_SPI1 (void)
{
	uint8_t i = dg;
	do
	{
		Send_SPI1(i, 0xF);
	} while (--i);
}
void Number_SPI1(volatile long n)
{
	uint8_t ng = 0;
	if(n < 0)
	{
		ng = 1;
		n*=-1;
	}
	uint8_t i = 8;
	do
	{
		Send_SPI1(i--, n%10);
		n/=10;
	} while(n);
	if(ng)
	{
		Send_SPI1(i,0x0A);
	}
}
void Init_SPI1 (void)
{
		Send_SPI1(0x09,0xFF);
		Send_SPI1(0x0B,dg-1);
		Send_SPI1(0x0A,0x02);
		Send_SPI1(0x0C,0x01);
		Clear_SPI1();
}
//////////////////////////////////////////////////////////////////////////////

#define SPI2_Enable		HAL_GPIO_WritePin(GPIOB, GPIO_PIN_12, GPIO_PIN_RESET)
#define SPI2_Disable 	HAL_GPIO_WritePin(GPIOB, GPIO_PIN_12, GPIO_PIN_SET)


void Send_SPI2 (uint8_t rg, uint8_t dt)
{
	SPI2_Enable;
	Buf_SPI2[0] = rg;
	HAL_SPI_Transmit (&hspi2, (uint8_t*)Buf_SPI2, 1, 1000);
	Buf_SPI2[0] = dt;
	HAL_SPI_Transmit (&hspi2, (uint8_t*)Buf_SPI2, 1, 1000);
	SPI2_Disable;
}
void Clear_SPI2 (void)
{
	uint8_t i = dg;
	do
	{
		Send_SPI2(i, 0xF);
	} while (--i);
}
void Number_SPI2(volatile long n)
{
	uint8_t ng = 0;
	if(n < 0)
	{
		ng = 1;
		n*=-1;
	}
	uint8_t i = 8;
	do
	{
		Send_SPI2(i--, n%10);
		n/=10;
	} while(n);
	if(ng)
	{
		Send_SPI2(i,0x0A);
	}
}
void Init_SPI2 (void)
{
		Send_SPI2(0x09,0xFF);
		Send_SPI2(0x0B,dg-1);
		Send_SPI2(0x0A,0x02);
		Send_SPI2(0x0C,0x01);
		Clear_SPI2();
}
