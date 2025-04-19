# Custom Mediator for .NET 9

This repository demonstrates the implementation and usage of a **Custom Mediator** in .NET 9.

The solution is divided into two main projects:

1. **MyCustomerMediator** – The core implementation of the custom Mediator logic.
2. **ExampleMediatorUse** – A consumer project that uses the NuGet package generated from `MyCustomerMediator`.

---

## 📁 Project Structure

```
custom_mediator_net9/
│
├── ExampleMediatorUse/        # Consumer project that uses the custom Mediator
├── MyCustomerMediator/        # Implementation of the custom Mediator
├── ExampleMediatorUse.sln     # Solution file for consumer project
├── MyCustomerMediator.sln     # Solution file for Mediator library
```

---

## 🛠️ How to Use

### Step 1: Clone the Repository

```bash
git clone https://github.com/Tayyab94/custom_mediator_net9.git
cd custom_mediator_net9
```

---

### Step 2: Build the Custom Mediator Project

Navigate to the `MyCustomerMediator` directory:

```bash
cd MyCustomerMediator
dotnet build
```

After build, a `.nuspec` file will be generated. You can use this to create a NuGet package.

---

### Step 3: Create a NuGet Package

Run the following command to pack your custom Mediator:

```bash
dotnet pack
```

The `.nupkg` file will be generated in the `bin/Debug` or `bin/Release` folder.

---

### Step 4: Use the Package in Another Project

1. Navigate to `ExampleMediatorUse`.
2. Add the generated `.nupkg` to the project as a local NuGet package:

```bash
dotnet add package MyCustomerMediator --source <path-to-nupkg-folder>
```

Replace `<path-to-nupkg-folder>` with the absolute or relative path where your `.nupkg` file is located.

---

### Step 5: Run the ExampleMediatorUse Project

Once the package is installed:

```bash
cd ExampleMediatorUse
dotnet run
```

This project demonstrates how to utilize the custom Mediator package in a real-world scenario.

---

## 🧩 Why Use This?

This custom Mediator implementation helps decouple your application's logic by handling:

- Command/Query dispatching
- Centralized request processing
- Improved separation of concerns

---

## 🧑‍💻 Author

**Muhammad Tayyab**  
[GitHub Profile](https://github.com/Tayyab94)

---

## 📄 License

This project is licensed under the MIT License.

---

## 📌 Notes

- Compatible with .NET 9
- Lightweight, no external dependencies
- Designed for learning and production-ready applications

```
