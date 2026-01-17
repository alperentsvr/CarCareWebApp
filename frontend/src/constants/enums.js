export const TRANSACTION_STATUS = {
  PENDING: {
    id: 0,
    label: "Bekliyor",
    color: "bg-orange-100 text-orange-800 border-orange-200 dark:bg-orange-900/30 dark:text-orange-300 dark:border-orange-800"
  },
  IN_PROGRESS: {
    id: 1,
    label: "İşlemde",
    color: "bg-blue-100 text-blue-800 border-blue-200 dark:bg-blue-900/30 dark:text-blue-300 dark:border-blue-800"
  },
  COMPLETED: {
    id: 2,
    label: "Tamamlandı",
    color: "bg-green-100 text-green-800 border-green-200 dark:bg-green-900/30 dark:text-green-300 dark:border-green-800"
  },
  CANCELLED: {
    id: 3,
    label: "İptal",
    color: "bg-red-100 text-red-800 border-red-200 dark:bg-red-900/30 dark:text-red-300 dark:border-red-800"
  }
};

// Helper to get status object by ID
export const getStatusById = (id) => {
  return Object.values(TRANSACTION_STATUS).find(s => s.id === id) || TRANSACTION_STATUS.PENDING;
};
