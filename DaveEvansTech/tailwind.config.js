//
// After any changes run npm run buildcss
//
const colors = require('tailwindcss/colors');
module.exports = {
    purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor'
        ],
    },
  darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            colors: {
                primary: '#109248',
                secondary: '#ecc94b',
                'light-green': '#b8e3ca'
            }
        }
    },
  variants: {
    extend: {},
  },
  plugins: [],
}
