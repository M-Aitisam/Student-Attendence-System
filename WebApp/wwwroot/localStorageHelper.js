window.localStorageHelper = {
    /**
     * Retrieves an item from localStorage and parses it as JSON if possible.
     * @param {string} key - The key of the item to retrieve.
     * @returns {string|null} - The stored string or null if not found or an error occurs.
     */
    getItem: function (key) {
        try {
            const item = localStorage.getItem(key);
            // Return the raw string or null if the item does not exist
            return item !== null ? item : null;
        } catch (e) {
            console.error(`Error retrieving key "${key}" from localStorage:`, e);
            return null;
        }
    },

    /**
     * Stores an item in localStorage after serializing it as JSON if it is an object.
     * @param {string} key - The key to store the value under.
     * @param {string|object} value - The value to store. Can be a string or an object.
     */
    setItem: function (key, value) {
        try {
            const valueToStore = typeof value === "object" ? JSON.stringify(value) : value;
            localStorage.setItem(key, valueToStore);
        } catch (e) {
            console.error(`Error setting key "${key}" in localStorage:`, e);
        }
    },

    /**
     * Removes an item from localStorage.
     * @param {string} key - The key of the item to remove.
     */
    removeItem: function (key) {
        try {
            localStorage.removeItem(key);
        } catch (e) {
            console.error(`Error removing key "${key}" from localStorage:`, e);
        }
    },

    /**
     * Clears all items from localStorage.
     */
    clear: function () {
        try {
            localStorage.clear();
        } catch (e) {
            console.error("Error clearing localStorage:", e);
        }
    },

    /**
     * Checks if a key exists in localStorage.
     * @param {string} key - The key to check.
     * @returns {boolean} - True if the key exists, false otherwise.
     */
    exists: function (key) {
        try {
            return localStorage.getItem(key) !== null;
        } catch (e) {
            console.error(`Error checking existence of key "${key}" in localStorage:`, e);
            return false;
        }
    },

    /**
     * Retrieves all keys currently stored in localStorage.
     * @returns {Array<string>} - An array of keys in localStorage.
     */
    getAllKeys: function () {
        try {
            return Object.keys(localStorage);
        } catch (e) {
            console.error("Error retrieving keys from localStorage:", e);
            return [];
        }
    },

    /**
     * Retrieves all items in localStorage as key-value pairs.
     * @returns {object} - An object containing all key-value pairs from localStorage.
     */
    getAllItems: function () {
        try {
            const items = {};
            Object.keys(localStorage).forEach(key => {
                items[key] = localStorage.getItem(key);
            });
            return items;
        } catch (e) {
            console.error("Error retrieving all items from localStorage:", e);
            return {};
        }
    }
};
