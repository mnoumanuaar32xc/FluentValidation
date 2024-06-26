**FluentValidation**

FluentValidation is a popular .NET library for building strongly-typed validation rules. It allows you to write validation logic in a fluent and expressive manner and supports complex validation scenarios.
FluentValidation provides an elegant and efficient way to handle server-side validation. It removes the necessity for numerous IF checks and extensive code, allowing developers to write cleaner, more maintainable code. By incorporating the FluentValidation library into your project, you can simplify your validation logic and focus on other core functionalities. Its fluent interface makes it easy to understand and maintain, significantly reducing development time and effort. This powerful tool ensures that your validation rules are centralized and consistent across your application.
Using FluentValidation offers several benefits, including:

1. **Cleaner Code**:
   - FluentValidation allows you to separate validation logic from business logic, resulting in cleaner, more maintainable code.
   
2. **Strongly Typed**:
   - It provides a strongly typed model, which reduces runtime errors and provides better IntelliSense support in IDEs like Visual Studio.

3. **Readable Syntax**:
   - The fluent interface makes the validation rules easy to read and understand. It uses a natural, chainable syntax that closely resembles natural language.

4. **Reusable Rules**:
   - Validation rules can be encapsulated into separate classes, making them reusable across different models and projects.

5. **Customization and Extensibility**:
   - You can easily create custom validation rules and combine or extend existing ones. This makes the library highly adaptable to unique business requirements.

6. **Support for Complex Scenarios**:
   - FluentValidation supports complex validation scenarios, such as conditional validation, cross-property validation, and hierarchical validation.

7. **Localization**:
   - Validation messages can be easily localized, which is useful for applications that need to support multiple languages.
     
8. **Asynchronous Validation**: 
    - FluentValidation supports asynchronous validation, which is particularly useful for scenarios involving database checks or other IO-bound operations that should not block the main thread.

9. **Integration with Dependency Injection**:
    - FluentValidation integrates seamlessly with dependency injection frameworks, making it easier to manage lifetimes and dependencies of validators.

10. **Error Message Customization**:
    - You can easily customize error messages, including using placeholders for dynamic content, to provide more informative and user-friendly validation feedback.

11. **Validation of Collections and Child Objects**:
    - FluentValidation offers support for validating collections and child objects within a model, ensuring comprehensive validation coverage.

12. **Built-in Validators**:
    - The library comes with a wide array of built-in validators (e.g., NotEmpty, Length, Email, etc.), which helps accelerate development by covering common validation needs out of the box.

13. **MVC and Web API Integration**:
    - FluentValidation integrates nicely with ASP.NET MVC and ASP.NET Core, allowing you to plug it into the model binding and validation pipeline easily.

14. **Testability**:
    - Validators are easy to test using unit tests because they are simple classes that don’t require any special setup or infrastructure
   

  **Implementation**
1. FluentValidation.AspNetCor is a Nuget Library
  ![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/3b97d108-ea10-452b-8179-1afebe0bce79)

2. Create a Web Api with .net 6
3. create a Model class Person
   ![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/899b5125-593a-4293-b9af-16b97746be22)\
4. create a PersonValidator class which get all parameters for validation
   **RuleFor**  an IRuleBuilder instance on which validators can be defined
in ruleFor you need to select parameter of a class which class passed intoAbstractValidator, AbstractValidator<Person>
   
![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/9d9eaf3f-c101-476f-8356-3c021d4c4bda)
5. create a TestValidation Api Method and consume it as like bellow.
![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/cc19d225-ab34-4a9e-92bd-fc26bfb61a34)

**Output**
![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/06d034a0-afcc-43fc-be36-d7a3e82620ee)

curl -X 'POST' \
  'https://localhost:7103/api/Validationtest?email=nouman&name=Nouman&age=30' \
  -H 'accept: */*' \
  -d ''
  ![image](https://github.com/mnoumanuaar32xc/FluentValidation/assets/8413883/c5339cb6-5b58-418a-9b02-91a7bf496799)

  


