# React vs React Native

A comparison of React and React Native, highlighting key differences and similarities between these related technologies.

## Core Concepts

| Feature | React | React Native |
|---------|-------|--------------|
| Platform | Web browsers | Mobile devices |
| DOM | HTML DOM | Native components |
| Styling | CSS | StyleSheet API |
| Navigation | React Router | React Navigation |
| Rendering | Web view | Native UI |

## Key Differences

1. **Components**
   - React: `<div>`, `<span>`, `<p>`
   - React Native: `<View>`, `<Text>`, `<Image>`

2. **Styling**
   - React: CSS, SASS, styled-components
   - React Native: StyleSheet API, limited CSS subset

3. **Platform Specific Code**
   - React: Browser compatibility
   - React Native: iOS/Android specific code

4. **Development Environment**
   - React: Browser dev tools
   - React Native: Mobile simulators/emulators

## Similarities

1. **JSX Syntax**
   ```jsx
   // Works in both React and React Native
   function MyComponent() {
     return (
       <View>
         <Text>Hello World</Text>
       </View>
     );
   }
   ```

2. **Component Lifecycle**
   - Same lifecycle methods
   - Hooks work the same way
   - State management principles

3. **Development Principles**
   - Component-based architecture
   - Unidirectional data flow
   - Virtual DOM concept

## When to Use Which

### Choose React for:
- Web applications
- Complex browser interactions
- SEO requirements
- Progressive Web Apps

### Choose React Native for:
- Native mobile apps
- Cross-platform mobile development
- Native device feature access
- App store distribution

## Related Topics
- [[What is React Native]]
- [[Development Environment]]
- [[Basic Components]]
