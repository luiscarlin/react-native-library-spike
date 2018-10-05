
# react-native-library-spike

## Getting started

`$ npm install react-native-library-spike --save`

### Mostly automatic installation

`$ react-native link react-native-library-spike`

### Manual installation


#### iOS
git lo
1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-library-spike` and add `RNLibrarySpike.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLibrarySpike.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLibrarySpikePackage;` to the imports at the top of the file
  - Add `new RNLibrarySpikePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-library-spike'
  	project(':react-native-library-spike').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-library-spike/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-library-spike')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLibrarySpike.sln` in `node_modules/react-native-library-spike/windows/RNLibrarySpike.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Library.Spike.RNLibrarySpike;` to the usings at the top of the file
  - Add `new RNLibrarySpikePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNLibrarySpike from 'react-native-library-spike';

// TODO: What to do with the module?
RNLibrarySpike;
```
