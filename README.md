# Payment Module using Strategy Pattern

This project implements a payment module in C# using the Strategy design pattern. The payment module supports different payment methods such as credit card, debit card, PIX, and boleto, each implemented as a separate strategy.

## Overview

The Strategy pattern is a behavioral design pattern that allows defining a family of algorithms, encapsulating each one, and making them interchangeable. In the context of this project, the Strategy pattern enables different payment methods to be implemented as separate strategies with a common interface, making them interchangeable in the payment module.

## Program Operation

The program allows the user to select the desired payment method from a menu. Once selected, the corresponding payment service is identified, and the function to process the payment is called.

## Running the Project

To run the project, follow these steps:

1. Clone the repository:

    ```bash
    git clone https://github.com/marlon-cesar/StrategyPattern
    ```

2. Navigate to the project directory:

    ```bash
    cd StrategyPattern
    ```

3. Run the program:

    ```bash
    dotnet run
    ```

This will compile and run the program, displaying the menu to select the payment method and processing the payment according to the user's choice.

## Contributing

Feel free to contribute with improvements to this example. Just open an issue or submit a pull request.
