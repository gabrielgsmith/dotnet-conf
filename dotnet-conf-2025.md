---
marp: true
theme: default
class: lead
paginate: true
backgroundColor: #fff
# backgroundImage: url('https://marp.app/assets/hero-background.svg')
style: |
  section {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  }
  h1 {
    color: #512BD4;
    font-weight: 700;
  }
  h2 {
    color: #512BD4;
  }
  h3 {
    color: #68217A;
  }
  strong {
    color: #512BD4;
  }
  a {
    color: #0078D4;
  }
  code {
    background: #f5f2f0;
    color: #512BD4;
  }
  pre {
    background: #1E1E1E;
    border-radius: 8px;
  }
  pre code {
    color: #D4D4D4;
  }
  section.title {
    background: linear-gradient(135deg, #512BD4 0%, #68217A 100%);
    color: white;
  }
  section.title h1, section.title h2, section.title p {
    color: white;
  }
  section.section-break {
    background: linear-gradient(135deg, #0078D4 0%, #512BD4 100%);
    color: white;
    text-align: center;
  }
  section.section-break h1, section.section-break h2 {
    color: white;
  }
  .highlight {
    background: #FFF4CE;
    padding: 2px 8px;
    border-radius: 4px;
  }
  .columns {
    display: grid;
    grid-template-columns: repeat(2, minmax(0, 1fr));
    gap: 1rem;
  }
  ul {
    line-height: 1.8;
  }
  footer {
    color: #666;
  }
---

<!-- _class: invert -->
<!-- _paginate: false -->

# .NET Conf 2025

## The Future of Modern Development

### November 11-13, 2025

---

<!-- Speaker Notes: 30 seconds
Welcome everyone! Today we're diving into the exciting announcements from .NET Conf 2025, Microsoft's flagship developer event for the .NET ecosystem.
-->

# About the Speaker

**[Your Name]**
[Your Title/Role]

- .NET Developer & Enthusiast
- [Your Expertise]
- [Contact/Social Media]

---

<!-- Speaker Notes: 30 seconds
Quick table of contents to orient everyone on what we'll cover today.
-->

# Agenda

1. **Event Overview** - .NET Conf 2025 Highlights
2. **.NET 10** - Long-Term Support Release
3. **Visual Studio 2026** - Modern Development Experience
4. **Aspire 13** - Cloud-Native Beyond .NET
5. **GitHub Copilot** - AI-Powered Development
6. **Microsoft Agent Framework** - Building AI Agents
7. **Community & What's Next**

<!-- _footer: "25-minute journey through .NET's biggest announcements" -->

---

<!-- _class: section-break -->

# Event Overview
## .NET Conf 2025

---

<!-- Speaker Notes: 1 minute
.NET Conf 2025 was a massive success, celebrating 15 years of this community-driven event. The scale and reach continue to grow year after year.
-->

# .NET Conf 2025: By The Numbers

<div class="columns">

<div>

## Event Details
- **Dates:** November 11-13, 2025
- **Format:** Virtual & Global
- **Anniversary:** 15th Year 🎉
- **Live Viewers:** 100,000+
- **Extended:** Local events through Jan 15, 2026

</div>

<div>

## Conference Structure
- **Day 1:** Keynote & Major Launches
- **Day 2:** Deep Technical Dives
- **Day 3:** Community Showcase
- **Student Zone:** Special track for learners

</div>

</div>

---

<!-- Speaker Notes: 45 seconds
The global reach of .NET Conf shows the vibrant, worldwide community. Local events let developers connect in person after the virtual conference.
-->

# Global Community Impact

### Why .NET Conf Matters

- **Open Source First** - All content freely available
- **Community Driven** - Speakers from around the world
- **Inclusive Learning** - Beginner to expert tracks
- **Local Events** - 100+ community-organized events globally
- **Free Access** - No registration fees, available to everyone

> "The .NET community is one of the most welcoming and innovative developer ecosystems in the world."

---

<!-- _class: section-break -->

# .NET 10
## Long-Term Support Release

---

<!-- Speaker Notes: 2 minutes
.NET 10 is the headliner - a Long-Term Support release that will be supported for 3 years. This is the release enterprises have been waiting for.
-->

# .NET 10: The Flagship Release

### Long-Term Support (LTS) - 3 Years of Support

<div class="columns">

<div>

## Key Benefits
- **Performance** - Faster than ever
- **Security** - Enhanced protection
- **Stability** - Enterprise-ready
- **Compatibility** - Smooth upgrades

</div>

<div>

## Release Timeline
- **Released:** November 11, 2025
- **Support Ends:** 2028
- **Recommended for:** Production workloads
- **Migration Path:** Clear from .NET 6/8

</div>

</div>

---

<!-- Speaker Notes: 1.5 minutes
Performance improvements are significant across the board - runtime, libraries, and compilation.
-->

# .NET 10: Performance Improvements

### Benchmarks Show Dramatic Gains

```csharp
// Example: Improved LINQ performance
var numbers = Enumerable.Range(1, 1000);

// .NET 10 optimization - up to 40% faster
var result = numbers
    .Where(n => n % 2 == 0)
    .Select(n => n * n)
    .ToArray();
```

**Highlights:**
- **JIT Compiler:** 15-20% faster compilation
- **GC (Garbage Collection):** Reduced pause times
- **LINQ:** Up to 40% performance boost
- **JSON Serialization:** 30% faster with System.Text.Json
- **Networking:** HTTP/3 optimizations

---

<!-- Speaker Notes: 1.5 minutes
Security is paramount in .NET 10, with enhanced cryptography and protection mechanisms.
-->

# .NET 10: Security Enhancements

### Enterprise-Grade Protection

<div class="columns">

<div>

## New Security Features
- Enhanced cryptography APIs
- Improved certificate validation
- Stronger default settings
- Security vulnerability scanning
- Supply chain security

</div>

<div>

## Secure by Default
```csharp
// New secure defaults
var builder = WebApplication
    .CreateBuilder(args);

// Auto-configured with:
// - HTTPS enforcement
// - HSTS enabled
// - Security headers
// - Rate limiting
```

</div>

</div>

---

<!-- Speaker Notes: 1.5 minutes
Major framework updates make .NET 10 comprehensive across all application types.
-->

# .NET 10: Framework Updates

### Modern Development Across All Platforms

**ASP.NET Core**
- Improved Razor Pages and Blazor performance
- Enhanced minimal APIs
- Built-in rate limiting improvements
- Better SignalR scalability

**.NET MAUI (Multi-platform App UI)**
- Desktop and mobile improvements
- Better performance on all platforms
- Enhanced controls and layouts
- Improved hot reload experience

**Windows Forms**
- High DPI improvements
- Modern control updates
- Accessibility enhancements

---

<!-- _class: section-break -->

# Visual Studio 2026
## Modern Development Experience

---

<!-- Speaker Notes: 1.5 minutes
Visual Studio 2026 represents a major leap forward with a complete UI overhaul using Fluent design.
-->

# Visual Studio 2026: Reimagined

### FluentUI-Based Modern Interface

<div class="columns">

<div>

## What's New
- **Modern UI** - Complete Fluent redesign
- **Performance** - Faster startup and response
- **Accessibility** - WCAG 2.2 compliant
- **Customization** - Flexible layouts
- **Dark Mode** - Enhanced themes

</div>

<div>

## Key Improvements
- 50% faster solution load
- Improved search functionality
- Better Git integration
- Enhanced debugging views
- Streamlined settings

</div>

</div>

---

<!-- Speaker Notes: 1 minute
Developer productivity features are the heart of VS 2026.
-->

# Visual Studio 2026: Developer Productivity

### Work Faster, Code Smarter

**Hot Reload Enhancements**
- Support for more scenarios
- Faster reload times
- Better error messaging
- Works across .NET MAUI, Blazor, and ASP.NET Core

**Razor Editing Improvements**
- IntelliSense improvements
- Better syntax highlighting
- Component navigation
- Real-time validation

**Enhanced Diagnostics**
- Performance profiler updates
- Memory leak detection
- CPU usage insights
- Database query optimization

---

<!-- Speaker Notes: 1 minute
GitHub Copilot integration is deeply embedded in VS 2026.
-->

# Visual Studio 2026: AI-Powered Coding

### GitHub Copilot Integration

```csharp
// Copilot suggestions in context
public class OrderService
{
    // Type comment: "Method to calculate order total with tax"
    // Copilot suggests:
    public decimal CalculateOrderTotal(Order order, decimal taxRate)
    {
        var subtotal = order.Items.Sum(i => i.Price * i.Quantity);
        var tax = subtotal * taxRate;
        return subtotal + tax;
    }
}
```

**Features:**
- Intelligent code completion
- Test generation (public preview)
- Code explanations and documentation
- Refactoring suggestions

---

<!-- _class: section-break -->

# Aspire 13
## Cloud-Native Beyond .NET

---

<!-- Speaker Notes: 1.5 minutes
Aspire 13 is a game-changer - it's no longer just for .NET, but supports the entire cloud-native ecosystem.
-->

# Aspire 13: Beyond .NET

### Cloud-Native Application Development for Everyone

<div class="columns">

<div>

## What is Aspire?
An opinionated stack for building **resilient**, **observable**, and **configurable** cloud-native applications.

Now supports:
- Node.js
- Python
- Java/Spring Boot
- Go
- And more!

</div>

<div>

## Core Principles
- **Code-First** - Infrastructure as code
- **Modular** - Pick what you need
- **Extensible** - Custom integrations
- **Flexible Deployment** - Any cloud, any container

</div>

</div>

---

<!-- Speaker Notes: 1.5 minutes
The developer experience is streamlined and intuitive.
-->

# Aspire 13: Developer Experience

### Code-First Cloud-Native Development

```csharp
// Aspire app host - orchestrate your entire stack
var builder = DistributedApplication.CreateBuilder(args);

// .NET API
var api = builder.AddProject<Projects.MyApi>("api");

// Node.js frontend
var frontend = builder.AddNpmApp("frontend", "../Frontend")
    .WithReference(api)
    .WithHttpEndpoint(port: 3000);

// PostgreSQL database
var db = builder.AddPostgres("postgres")
    .AddDatabase("mydb");

// Python ML service
var mlService = builder.AddPythonApp("ml-service", "../MLService")
    .WithReference(db);

builder.Build().Run();
```

---

<!-- Speaker Notes: 1 minute
Deployment flexibility is key - Aspire works anywhere.
-->

# Aspire 13: Flexible Deployment

### Deploy Anywhere

**Deployment Targets:**
- **Azure Container Apps** - Fully managed
- **Kubernetes** - Full control
- **Docker Compose** - Local development
- **AWS ECS/Fargate** - Amazon cloud
- **Google Cloud Run** - Google cloud

**Built-in Features:**
- Service discovery
- Configuration management
- Observability (logging, metrics, tracing)
- Health checks
- Resilience patterns (retry, circuit breaker)

---

<!-- _class: section-break -->

# GitHub Copilot
## AI-Powered Development

---

<!-- Speaker Notes: 1.5 minutes
GitHub Copilot has evolved from code completion to a comprehensive development assistant.
-->

# GitHub Copilot: Transform Your Workflow

### AI-Powered Development Assistant

<div class="columns">

<div>

## App Modernization
- **AI-Powered .NET Upgrades**
- Automatic code migration
- Framework version updates
- Dependency resolution
- Breaking change fixes

</div>

<div>

## Test Generation
- **Public Preview**
- Unit test creation
- Test coverage analysis
- Edge case identification
- Mock object generation

</div>

</div>

**New Capabilities:**
- Code assessments and reviews
- Test failure diagnosis and fixes
- Performance optimization suggestions
- Security vulnerability detection

---

<!-- Speaker Notes: 1.5 minutes
Let's see practical examples of what Copilot can do.
-->

# GitHub Copilot: Practical Examples

### Real-World Development Scenarios

**App Modernization Example:**
```csharp
// Copilot can upgrade from .NET Framework to .NET 10
// Old .NET Framework code
using System.Web.Mvc;
public class HomeController : Controller { }

// Copilot suggests .NET 10 migration:
using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller { }
// + Updates routing, DI, and configuration
```

**Unit Test Generation:**
```csharp
// Select method → Copilot generates tests
public decimal CalculateDiscount(decimal price, int quantity)
    => quantity > 10 ? price * 0.9m : price;

// Generated tests cover: normal case, bulk discount, edge cases
```

---

<!-- Speaker Notes: 1 minute
Copilot helps maintain code quality and catch issues early.
-->

# GitHub Copilot: Quality Assistance

### Test Failure Fixes & Code Assessment

**Test Failure Remediation:**
- Analyzes failing tests
- Suggests fixes with explanations
- Identifies root causes
- Prevents regression

**Code Assessment Features:**
- Best practice recommendations
- Code smell detection
- Architecture suggestions
- Performance anti-pattern identification
- Security vulnerability scanning

> "GitHub Copilot is like having a senior developer pair programming with you 24/7."

---

<!-- _class: section-break -->

# Microsoft Agent Framework
## Building AI Agents with .NET

---

<!-- Speaker Notes: 2 minutes
The Agent Framework is in public preview - this enables developers to build autonomous AI agents.
-->

# Microsoft Agent Framework for .NET

### Public Preview: Build Autonomous AI Agents

<div class="columns">

<div>

## What Are AI Agents?
Autonomous software that:
- Understands natural language
- Makes decisions
- Executes tasks
- Learns from interactions
- Integrates with systems

</div>

<div>

## Framework Features
- **Natural Language** - Human-like interaction
- **Open Standards** - Interoperable
- **Extensible** - Custom skills/tools
- **Integration** - Connect to existing systems
- **.NET Native** - First-class C# support

</div>

</div>

---

<!-- Speaker Notes: 1.5 minutes
Building an agent is straightforward with the framework.
-->

# Building Your First Agent

### Simple Example

```csharp
using Microsoft.Agents;
using Microsoft.Agents.Skills;

// Create an agent
var agent = new AgentBuilder()
    .WithName("CustomerServiceAgent")
    .WithDescription("Helps customers with orders")
    .AddSkill<OrderLookupSkill>()
    .AddSkill<RefundProcessingSkill>()
    .WithLanguageModel("gpt-4")
    .Build();

// Interact with natural language
var response = await agent.InvokeAsync(
    "Find order #12345 and process a refund"
);

Console.WriteLine(response.Message);
// Agent: "I found order #12345 for John Doe.
//         Refund of $59.99 has been processed."
```

---

<!-- Speaker Notes: 1.5 minutes
Real-world use cases demonstrate the power of AI agents.
-->

# Agent Framework: Use Cases

### Real-World Applications

**Customer Service**
- Automated support chatbots
- Order tracking and management
- FAQ assistance
- Escalation handling

**Business Process Automation**
- Document processing
- Data entry and validation
- Workflow orchestration
- Report generation

**Development Tools**
- Code review assistants
- Documentation generators
- Bug triage automation
- DevOps task automation

---

<!-- Speaker Notes: 1 minute
Integration capabilities make agents practical for enterprise use.
-->

# Agent Framework: Integration

### Connect to Your Existing Systems

```csharp
// Define custom skills that connect to your systems
public class OrderLookupSkill : IAgentSkill
{
    [AgentFunction("Look up order by ID")]
    public async Task<Order> LookupOrder(
        [Parameter("Order ID")] string orderId)
    {
        // Connect to your existing order system
        return await _orderService.GetOrderAsync(orderId);
    }

    [AgentFunction("Process refund for order")]
    public async Task<RefundResult> ProcessRefund(
        [Parameter("Order ID")] string orderId,
        [Parameter("Reason")] string reason)
    {
        // Integrate with payment system
        return await _paymentService.ProcessRefundAsync(orderId, reason);
    }
}
```

---

<!-- _class: section-break -->

# Additional Innovations
## More from .NET Conf 2025

---

<!-- Speaker Notes: 1.5 minutes
Beyond the major announcements, there are several other important updates.
-->

# Cloud-Native Development Focus

### Modern Application Architecture

**Container-First Development**
- Optimized container images
- Smaller base images (50% reduction)
- Faster cold starts
- Better layer caching

**Microservices Support**
- Service mesh integration
- Distributed tracing
- Load balancing improvements
- Service discovery enhancements

**Serverless Improvements**
- Azure Functions .NET 10 support
- Faster cold starts
- Better scaling
- Improved triggers and bindings

---

<!-- Speaker Notes: 1 minute
MCP support enables new integration scenarios.
-->

# Model Context Protocol (MCP)

### Open Standard for AI Integration

**What is MCP?**
An open protocol that enables AI systems to securely connect to data sources and tools.

**Benefits for .NET Developers:**
- Standardized way to expose data to AI
- Works with multiple AI platforms
- Secure context sharing
- Tool integration for AI agents
- Open source and extensible

**Use Cases:**
- Connect AI to databases
- Expose APIs to AI systems
- Share business logic with AI agents
- Create custom AI tools

---

<!-- Speaker Notes: 1 minute
Community engagement continues to grow.
-->

# Community & Ecosystem

### The Heart of .NET

<div class="columns">

<div>

## Community Growth
- **100K+ Live Viewers**
- **100+ Local Events**
- **1000+ Speakers**
- **Global Participation**
- **Open Source Contributors**

</div>

<div>

## Get Involved
- Join local .NET meetups
- Contribute to open source
- Attend .NET Conf events
- Share your knowledge
- Build and showcase projects

</div>

</div>

**Resources:**
- [dot.net](https://dot.net) - Official site
- [GitHub.com/dotnet](https://github.com/dotnet) - Source code
- [Learn.microsoft.com](https://learn.microsoft.com) - Documentation
- [.NET Foundation](https://dotnetfoundation.org) - Community support

---

<!-- Speaker Notes: 1 minute
Looking ahead at what's coming next.
-->

# What's Next?

### The Road Ahead

**Immediate Next Steps:**
- Download .NET 10 SDK
- Try Visual Studio 2026 preview
- Explore Aspire 13 templates
- Experiment with Agent Framework
- Enable GitHub Copilot features

**Coming Soon:**
- .NET 11 previews (2026)
- More AI integrations
- Enhanced cloud-native tools
- Community contributions
- Local .NET Conf events (through Jan 15, 2026)

**Stay Updated:**
- Follow the .NET Blog
- Subscribe to .NET YouTube channel
- Join community forums

---

<!-- Speaker Notes: 1 minute
Key takeaways from everything we've covered.
-->

# Key Takeaways

## Why .NET Conf 2025 Matters

1. **.NET 10 LTS** - Production-ready, long-term support for enterprise
2. **AI Integration** - GitHub Copilot and Agent Framework transform development
3. **Visual Studio 2026** - Modern, fast, and intelligent IDE
4. **Aspire 13** - Cloud-native development for any language
5. **Community First** - Open, inclusive, and globally connected

### The .NET ecosystem is stronger than ever

---

<!-- _class: section-break -->

# Demo Resources
## Try It Yourself

---

<!-- Speaker Notes: 1 minute
Provide attendees with resources to get started.
-->

# Getting Started Resources

### Everything You Need to Begin

**Download & Install:**
```bash
# Install .NET 10 SDK
winget install Microsoft.DotNet.SDK.10

# Create new Aspire app
dotnet new aspire-starter -o MyCloudApp
cd MyCloudApp
dotnet run
```

**Learning Paths:**
- Microsoft Learn: .NET 10 Learning Path
- Aspire 13 Workshop
- Agent Framework Tutorials
- GitHub Copilot for .NET Developers

**Sample Code:** [github.com/dotnet/samples](https://github.com/dotnet/samples)

---

<!-- Speaker Notes: 30 seconds
Wrap up with call to action.
-->

# Join the .NET Community

### Connect & Contribute

<div class="columns">

<div>

**Online:**
- Twitter: @dotnet
- Discord: .NET Community
- Reddit: r/dotnet
- Stack Overflow: .net tag

</div>

<div>

**In Person:**
- Find local .NET meetups
- Attend regional conferences
- Organize a study group
- Speak at events

</div>

</div>

**Contribute:**
The .NET platform is open source and welcomes contributions of all kinds!

---

<!-- _class: title -->
<!-- _paginate: false -->

# Thank You!

## Questions?

### Let's Build Amazing Things with .NET 10

**Contact:**
[Your Email]
[Your Twitter/LinkedIn]
[Your Website]

**Resources:** dot.net/conf

---

<!-- Speaker Notes: 2-3 minutes for Q&A
Leave time for audience questions and discussion.
-->

# Additional Resources

### Deep Dive Links

**Documentation:**
- [.NET 10 Release Notes](https://github.com/dotnet/core/releases)
- [Visual Studio 2026 What's New](https://learn.microsoft.com/visualstudio/releases/2026/release-notes)
- [Aspire 13 Documentation](https://learn.microsoft.com/dotnet/aspire)
- [Microsoft Agent Framework Docs](https://learn.microsoft.com/agents)

**Videos:**
- .NET Conf 2025 Recordings
- Channel 9: .NET Series
- Visual Studio Toolbox

**Community:**
- .NET Foundation Projects
- Awesome .NET - Curated Resources

---

<!-- _paginate: false -->
<!-- _class: title -->

# Appendix
## Additional Slides for Deep Dives

---

# Backup: .NET 10 Performance Details

### Detailed Benchmark Comparisons

| Scenario | .NET 8 | .NET 10 | Improvement |
|----------|--------|---------|-------------|
| JSON Serialization | 100ms | 70ms | 30% |
| LINQ Queries | 150ms | 90ms | 40% |
| HTTP Requests | 50ms | 40ms | 20% |
| Startup Time | 800ms | 600ms | 25% |

**Memory Usage:**
- 15% reduction in average heap size
- 30% faster GC collections
- Improved memory allocation patterns

---

# Backup: Migration Guide

### Upgrading to .NET 10

**From .NET 6/8:**
```bash
# Update global.json
{
  "sdk": {
    "version": "10.0.0"
  }
}

# Update project files
<TargetFramework>net10.0</TargetFramework>

# Use upgrade assistant
dotnet tool install -g upgrade-assistant
dotnet upgrade-assistant upgrade MyProject.csproj
```

**Breaking Changes:** Minimal - mostly API improvements
**Recommended Approach:** Test thoroughly, upgrade non-critical apps first

