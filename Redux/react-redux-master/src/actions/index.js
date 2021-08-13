let _id = 1;
export function uniqueId() {
  return _id++;
}
//Action Creator (factory)
export function createTask({ title, description }) {
  return {
    type: 'CREATE_TASK',
    payload: {
      id: uniqueId(),
      title,
      description,
      status: 'Unstarted'
    },
  };
}

export function editTask(id, params = {}) {
  return {
    type: 'EDIT_TASK',
    payload: {
      id,
      params,
    },
  };
}
